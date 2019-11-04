﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FastEngine_Core_TCPSessionWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FastEngine.Core.TCPSession), typeof(FastEngine.MonoSingleton<FastEngine.Core.TCPSession>));
		L.RegFunction("Initialize", Initialize);
		L.RegFunction("Connecte", Connecte);
		L.RegFunction("Disconnecte", Disconnecte);
		L.RegFunction("Send", Send);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("isConnected", get_isConnected, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Initialize(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FastEngine.Core.TCPSession.Initialize();
				return 0;
			}
			else if (count == 1)
			{
				bool arg0 = LuaDLL.luaL_checkboolean(L, 1);
				FastEngine.Core.TCPSession.Initialize(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FastEngine.Core.TCPSession.Initialize");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Connecte(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FastEngine.Core.TCPSession.Connecte();
				return 0;
			}
			else if (count == 2)
			{
				string arg0 = ToLua.CheckString(L, 1);
				int arg1 = (int)LuaDLL.luaL_checknumber(L, 2);
				FastEngine.Core.TCPSession.Connecte(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FastEngine.Core.TCPSession.Connecte");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Disconnecte(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			FastEngine.Core.TCPSession.Disconnecte();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Send(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<int>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				FastEngine.Core.TCPSession.Send(arg0);
				return 0;
			}
			else if (count == 1 && TypeChecker.CheckTypes<FastEngine.Core.SocketPack>(L, 1))
			{
				FastEngine.Core.SocketPack arg0 = (FastEngine.Core.SocketPack)ToLua.ToObject(L, 1);
				FastEngine.Core.TCPSession.Send(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<Google.Protobuf.IMessage>(L, 2))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				Google.Protobuf.IMessage arg1 = (Google.Protobuf.IMessage)ToLua.ToObject(L, 2);
				FastEngine.Core.TCPSession.Send(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<string>(L, 2))
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				FastEngine.Core.TCPSession.Send(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FastEngine.Core.TCPSession.Send");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_isConnected(IntPtr L)
	{
		try
		{
			LuaDLL.lua_pushboolean(L, FastEngine.Core.TCPSession.isConnected);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

