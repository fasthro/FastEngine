﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FastEngine_FUI_FWindowStateWrap
{
	public static void Register(LuaState L)
	{
		L.BeginEnum(typeof(FastEngine.FUI.FWindowState));
		L.RegVar("Init", get_Init, null);
		L.RegVar("Loading", get_Loading, null);
		L.RegVar("Showing", get_Showing, null);
		L.RegVar("Hided", get_Hided, null);
		L.RegVar("Destory", get_Destory, null);
		L.RegFunction("IntToEnum", IntToEnum);
		L.EndEnum();
		TypeTraits<FastEngine.FUI.FWindowState>.Check = CheckType;
		StackTraits<FastEngine.FUI.FWindowState>.Push = Push;
	}

	static void Push(IntPtr L, FastEngine.FUI.FWindowState arg)
	{
		ToLua.Push(L, arg);
	}

	static bool CheckType(IntPtr L, int pos)
	{
		return TypeChecker.CheckEnumType(typeof(FastEngine.FUI.FWindowState), L, pos);
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Init(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FWindowState.Init);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Loading(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FWindowState.Loading);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Showing(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FWindowState.Showing);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Hided(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FWindowState.Hided);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Destory(IntPtr L)
	{
		ToLua.Push(L, FastEngine.FUI.FWindowState.Destory);
		return 1;
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int IntToEnum(IntPtr L)
	{
		int arg0 = (int)LuaDLL.lua_tonumber(L, 1);
		FastEngine.FUI.FWindowState o = (FastEngine.FUI.FWindowState)arg0;
		ToLua.Push(L, o);
		return 1;
	}
}

