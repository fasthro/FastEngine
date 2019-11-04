﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FastEngine_Core_TCPSessionServiceWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FastEngine.Core.TCPSessionService), typeof(System.Object));
		L.RegFunction("AddListener", AddListener);
		L.RegFunction("RemoveListener", RemoveListener);
		L.RegFunction("Broadcast", Broadcast);
		L.RegFunction("Clear", Clear);
		L.RegFunction("New", _CreateFastEngine_Core_TCPSessionService);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFastEngine_Core_TCPSessionService(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 0)
			{
				FastEngine.Core.TCPSessionService obj = new FastEngine.Core.TCPSessionService();
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FastEngine.Core.TCPSessionService.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AddListener(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<int, FastEngine.Core.TCPSessionServiceEventCallabck>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				FastEngine.Core.TCPSessionServiceEventCallabck arg1 = (FastEngine.Core.TCPSessionServiceEventCallabck)ToLua.ToObject(L, 2);
				FastEngine.Core.TCPSessionService.AddListener(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<FastEngine.Core.TCPSessionServiceBuiltIn, FastEngine.Core.TCPSessionServiceBuiltInEventCallabck>(L, 1))
			{
				FastEngine.Core.TCPSessionServiceBuiltIn arg0 = (FastEngine.Core.TCPSessionServiceBuiltIn)ToLua.ToObject(L, 1);
				FastEngine.Core.TCPSessionServiceBuiltInEventCallabck arg1 = (FastEngine.Core.TCPSessionServiceBuiltInEventCallabck)ToLua.ToObject(L, 2);
				FastEngine.Core.TCPSessionService.AddListener(arg0, arg1);
				return 0;
			}
			else if (count == 3)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				LuaTable arg1 = ToLua.CheckLuaTable(L, 2);
				LuaFunction arg2 = ToLua.CheckLuaFunction(L, 3);
				FastEngine.Core.TCPSessionService.AddListener(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FastEngine.Core.TCPSessionService.AddListener");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RemoveListener(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				FastEngine.Core.TCPSessionService.RemoveListener(arg0);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<int, FastEngine.Core.TCPSessionServiceEventCallabck>(L, 1))
			{
				int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
				FastEngine.Core.TCPSessionServiceEventCallabck arg1 = (FastEngine.Core.TCPSessionServiceEventCallabck)ToLua.ToObject(L, 2);
				FastEngine.Core.TCPSessionService.RemoveListener(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<FastEngine.Core.TCPSessionServiceBuiltIn, FastEngine.Core.TCPSessionServiceBuiltInEventCallabck>(L, 1))
			{
				FastEngine.Core.TCPSessionServiceBuiltIn arg0 = (FastEngine.Core.TCPSessionServiceBuiltIn)ToLua.ToObject(L, 1);
				FastEngine.Core.TCPSessionServiceBuiltInEventCallabck arg1 = (FastEngine.Core.TCPSessionServiceBuiltInEventCallabck)ToLua.ToObject(L, 2);
				FastEngine.Core.TCPSessionService.RemoveListener(arg0, arg1);
				return 0;
			}
			else if (count == 3)
			{
				int arg0 = (int)LuaDLL.luaL_checknumber(L, 1);
				LuaTable arg1 = ToLua.CheckLuaTable(L, 2);
				LuaFunction arg2 = ToLua.CheckLuaFunction(L, 3);
				FastEngine.Core.TCPSessionService.RemoveListener(arg0, arg1, arg2);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FastEngine.Core.TCPSessionService.RemoveListener");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Broadcast(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1 && TypeChecker.CheckTypes<FastEngine.Core.SocketPack>(L, 1))
			{
				FastEngine.Core.SocketPack arg0 = (FastEngine.Core.SocketPack)ToLua.ToObject(L, 1);
				FastEngine.Core.TCPSessionService.Broadcast(arg0);
				return 0;
			}
			else if (count == 1 && TypeChecker.CheckTypes<FastEngine.Core.TCPSessionServiceBuiltIn>(L, 1))
			{
				FastEngine.Core.TCPSessionServiceBuiltIn arg0 = (FastEngine.Core.TCPSessionServiceBuiltIn)ToLua.ToObject(L, 1);
				FastEngine.Core.TCPSessionService.Broadcast(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FastEngine.Core.TCPSessionService.Broadcast");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Clear(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			FastEngine.Core.TCPSessionService.Clear();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}
