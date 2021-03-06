﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class FastEngine_AppWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(FastEngine.App), typeof(FastEngine.MonoSingleton<FastEngine.App>));
		L.RegFunction("AppRun", AppRun);
		L.RegFunction("AppQuit", AppQuit);
		L.RegFunction("BindCallback", BindCallback);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("runModel", get_runModel, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AppRun(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FastEngine.App obj = (FastEngine.App)ToLua.CheckObject<FastEngine.App>(L, 1);
			obj.AppRun();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int AppQuit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			FastEngine.App obj = (FastEngine.App)ToLua.CheckObject<FastEngine.App>(L, 1);
			obj.AppQuit();
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int BindCallback(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			FastEngine.App obj = (FastEngine.App)ToLua.CheckObject<FastEngine.App>(L, 1);
			FastEngine.AppBehaviour arg0 = (FastEngine.AppBehaviour)ToLua.CheckObject(L, 2, typeof(FastEngine.AppBehaviour));
			FastEngine.AppBehaviourCallback arg1 = (FastEngine.AppBehaviourCallback)ToLua.CheckDelegate<FastEngine.AppBehaviourCallback>(L, 3);
			obj.BindCallback(arg0, arg1);
			return 0;
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
	static int get_runModel(IntPtr L)
	{
		try
		{
			ToLua.Push(L, FastEngine.App.runModel);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

