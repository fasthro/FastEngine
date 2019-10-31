﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FastEngine_FUI_FWindowWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FastEngine.FUI.FWindow), typeof(FairyGUI.Window));
		L.RegFunction("ShowWindow", ShowWindow);
		L.RegFunction("HideWindow", HideWindow);
		L.RegFunction("RefreshWindow", RefreshWindow);
		L.RegFunction("Log", Log);
		L.RegFunction("LogError", LogError);
		L.RegFunction("LogWarning", LogWarning);
		L.RegFunction("New", _CreateFastEngine_FUI_FWindow);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("enabledLog", get_enabledLog, set_enabledLog);
		L.RegVar("logMark", get_logMark, set_logMark);
		L.RegVar("layer", get_layer, null);
		L.RegVar("state", get_state, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int _CreateFastEngine_FUI_FWindow(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 3)
			{
				FastEngine.FUI.FLayer arg0 = (FastEngine.FUI.FLayer)ToLua.CheckObject(L, 1, typeof(FastEngine.FUI.FLayer));
				string arg1 = ToLua.CheckString(L, 2);
				string arg2 = ToLua.CheckString(L, 3);
				FastEngine.FUI.FWindow obj = new FastEngine.FUI.FWindow(arg0, arg1, arg2);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else if (count == 4)
			{
				FastEngine.FUI.FLayer arg0 = (FastEngine.FUI.FLayer)ToLua.CheckObject(L, 1, typeof(FastEngine.FUI.FLayer));
				string arg1 = ToLua.CheckString(L, 2);
				string arg2 = ToLua.CheckString(L, 3);
				string[] arg3 = ToLua.CheckStringArray(L, 4);
				FastEngine.FUI.FWindow obj = new FastEngine.FUI.FWindow(arg0, arg1, arg2, arg3);
				ToLua.PushObject(L, obj);
				return 1;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to ctor method: FastEngine.FUI.FWindow.New");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int ShowWindow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)ToLua.CheckObject<FastEngine.FUI.FWindow>(L, 1);
			obj.ShowWindow();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int HideWindow(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 1)
			{
				FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)ToLua.CheckObject<FastEngine.FUI.FWindow>(L, 1);
				obj.HideWindow();
				return 0;
			}
			else if (count == 2)
			{
				FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)ToLua.CheckObject<FastEngine.FUI.FWindow>(L, 1);
				bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
				obj.HideWindow(arg0);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: FastEngine.FUI.FWindow.HideWindow");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int RefreshWindow(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)ToLua.CheckObject<FastEngine.FUI.FWindow>(L, 1);
			obj.RefreshWindow();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Log(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)ToLua.CheckObject<FastEngine.FUI.FWindow>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.Log(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogError(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)ToLua.CheckObject<FastEngine.FUI.FWindow>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.LogError(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LogWarning(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)ToLua.CheckObject<FastEngine.FUI.FWindow>(L, 1);
			string arg0 = ToLua.CheckString(L, 2);
			obj.LogWarning(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_enabledLog(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)o;
			bool ret = obj.enabledLog;
			LuaDLL.lua_pushboolean(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index enabledLog on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_logMark(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)o;
			string ret = obj.logMark;
			LuaDLL.lua_pushstring(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index logMark on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_layer(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)o;
			FastEngine.FUI.FLayer ret = obj.layer;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index layer on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_state(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)o;
			FastEngine.FUI.FWindowState ret = obj.state;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index state on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_enabledLog(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)o;
			bool arg0 = LuaDLL.luaL_checkboolean(L, 2);
			obj.enabledLog = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index enabledLog on a nil value");
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_logMark(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			FastEngine.FUI.FWindow obj = (FastEngine.FUI.FWindow)o;
			string arg0 = ToLua.CheckString(L, 2);
			obj.logMark = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o, "attempt to index logMark on a nil value");
		}
	}
}
