/*
 * @Author: fasthro
 * @Date: 2019-08-30 13:04:27
 * @Description: tcp 会话管理(发送，接收，异常处理)
 */
using System.Collections.Generic;
using Google.Protobuf;

namespace FastEngine.Core
{
    [MonoSingletonPath("FastEngine/Network")]
    public class TCPSession : MonoSingleton<TCPSession>
    {
        private SocketClient m_client;
        private bool m_isConnected { get { return m_client != null && m_client.isConnected; } }

        void Update()
        {
            if (m_client != null) m_client.Update();
        }

        #region internal api
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="enabledLog"></param>
        private void InternalInitialize(string ip, int port, bool enabledLog = false)
        {
            m_client = new SocketClient(ip, port, OnSocketEventCallback, enabledLog);
        }

        private void InternalConnecte()
        {
            if (!m_isConnected) m_client.Connect();
        }

        private void InternalDisconnecte()
        {
            if (m_isConnected) m_client.Disconnecte();
        }

        private void InternalSend(SocketPack pack)
        {
            if (m_isConnected) m_client.Send(pack);
        }

        private void InternalSend(int cmd, IMessage message)
        {
            if (m_isConnected) m_client.Send(cmd, message);
        }

        #endregion

        /// <summary>
        /// 回调处理
        /// </summary>
        /// <param name="args"></param>
        private void OnSocketEventCallback(SocketEventArgs args)
        {
            switch (args.socketState)
            {
                case SocketState.Received:
                    TCPSessionService.Broadcast(args.socketPack);
                    break;
                default:
                    break;
            }
        }

        #region API
        public static bool isConnected { get { return Instance.m_isConnected; } }
        public static void Initialize(string ip, int port, bool enabledLog = false) { Instance.InternalInitialize(ip, port, enabledLog); }
        public static void Connecte() { Instance.InternalConnecte(); }
        public static void Disconnecte() { Instance.InternalDisconnecte(); }
        public static void Send(int cmd) { Instance.InternalSend(SocketPackFactory.CreateWriter(cmd)); }
        public static void Send(SocketPack pack) { Instance.InternalSend(pack); }
        public static void Send(int cmd, IMessage message) { Instance.InternalSend(cmd, message); }
        #endregion
    }
}