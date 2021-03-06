/*
 * @Author: fasthro
 * @Date: 2019-08-30 13:04:27
 * @Description: tcp 会话管理(发送，接收，异常处理)
 */
using System.Collections.Generic;
using Google.Protobuf;
using LuaInterface;

namespace FastEngine.Core
{
    [MonoSingletonPath("FastEngine/TCPSession")]
    public class TCPSession : MonoSingleton<TCPSession>
    {
        private SocketClient m_client;
        private bool m_isConnected { get { return m_client != null && m_client.isConnected && m_client.isSocketConnected; } }
        private Dictionary<int, int> sessionDic = new Dictionary<int, int>();

        private Queue<SocketEventArgs> socketEventArgQueue = new Queue<SocketEventArgs>();

        void Update()
        {
            if (m_client != null) m_client.Update();

            if (socketEventArgQueue.Count > 0)
            {
                var args = socketEventArgQueue.Dequeue();

                switch (args.socketState)
                {
                    case SocketState.Received:
                        var pack = args.socketPack;
                        if (sessionDic.ContainsKey(pack.cmd)) pack.valid = pack.sessionId == sessionDic[pack.cmd];
                        else pack.valid = true;
                        TCPSessionService.Broadcast(args.socketPack);
                        break;
                    case SocketState.Connected:
                        TCPSessionService.Broadcast(TCPSessionServiceBuiltIn.Connected);
                        break;
                    case SocketState.Disconnected:
                        UnityEngine.Debug.Log("TCPSession 广播断线事件");
                        TCPSessionService.Broadcast(TCPSessionServiceBuiltIn.Disconnected);
                        break;
                    default:
                        break;
                }
            }
        }

        #region internal api
        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="enabledLog"></param>
        private void InternalInitialize(bool enabledLog = false)
        {
            m_client = new SocketClient(OnSocketEventCallback, enabledLog);
        }

        private void InternalConnecte(string ip, int port)
        {
            if (!m_isConnected) m_client.Connect(ip, port);
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
            if (m_isConnected)
            {
                var sessionId = m_client.Send(pack);
                if (!sessionDic.ContainsKey(pack.cmd))
                {
                    sessionDic.Add(pack.cmd, sessionId);
                }
                else sessionDic[pack.cmd] = sessionId;
            }
        }

        private void InternalSend(int cmd, IMessage message)
        {
            if (m_isConnected)
            {
                var sessionId = m_client.Send(cmd, message);
                if (!sessionDic.ContainsKey(cmd))
                {
                    sessionDic.Add(cmd, sessionId);
                }
                else sessionDic[cmd] = sessionId;
            }
        }

        #endregion

        /// <summary>
        /// 回调处理
        /// </summary>
        /// <param name="args"></param>
        private void OnSocketEventCallback(SocketEventArgs args)
        {
            socketEventArgQueue.Enqueue(args);
        }
        #region API
        public static bool isConnected { get { return Instance.m_isConnected; } }
        public static void Initialize(bool enabledLog = false) { Instance.InternalInitialize(enabledLog); }
        public static void Connecte() { Instance.InternalConnecte(); }
        public static void Connecte(string ip, int port) { Instance.InternalConnecte(ip, port); }
        public static void Disconnecte() { Instance.InternalDisconnecte(); }
        public static void Send(int cmd) { Instance.InternalSend(SocketPackFactory.CreateWriter(cmd)); }
        public static void Send(SocketPack pack) { Instance.InternalSend(pack); }
        public static void Send(int cmd, IMessage message) { Instance.InternalSend(cmd, message); }
        public static void Send(int cmd, LuaByteBuffer luabyte) { Instance.InternalSend(SocketPackFactory.CreateWriter(cmd, luabyte)); }
        public static void BroadcastError(int cmd, int errorCode) { TCPSessionService.Broadcast(SocketPackFactory.CreateError(cmd, errorCode)); }
        #endregion
    }
}