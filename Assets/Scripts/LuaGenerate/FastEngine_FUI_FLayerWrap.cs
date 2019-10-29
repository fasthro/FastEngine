﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FastEngine_FUI_FLayerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FastEngine.FUI.FLayer));
		L.RegVar("Scene", get_Scene, null);
		L.RegVar("SceneTop", get_SceneTop, null);
		L.RegVar("WindowBottom", get_WindowBottom, null);
		L.RegVar("Window", get_Window, null);
		L.RegVar("WindowTop", get_WindowTop, null);
		L.RegVar("Popup", get_Popup, null);
		L.RegVar("Guide", get_Guide, null);
		L.RegVar("Notification", get_Notification, null);
		L.RegVar("Net", get_Net, null);
		L.RegVar("Loader", get_Loader, null);
		L.RegVar("Forward", get_Forward, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<FastEngine.FUI.FLayer>.Check = CheckType;
		StackTraits<FastEngine.FUI.FLayer>.Push = Push;
	}

	static void Push(IntPtr L, FastEngine.FUI.FLayer arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FastEngine.FUI.FLayer), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Scene(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.Scene);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_SceneTop(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.SceneTop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WindowBottom(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.WindowBottom);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Window(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.Window);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_WindowTop(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.WindowTop);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Popup(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.Popup);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Guide(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.Guide);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Notification(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.Notification);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Net(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.Net);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Loader(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.Loader);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Forward(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FLayer.Forward);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		FastEngine.FUI.FLayer o = (FastEngine.FUI.FLayer)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

