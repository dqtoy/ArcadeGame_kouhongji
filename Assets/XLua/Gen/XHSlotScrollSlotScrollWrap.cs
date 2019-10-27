﻿#if USE_UNI_LUA
using LuaAPI = UniLua.Lua;
using RealStatePtr = UniLua.ILuaState;
using LuaCSFunction = UniLua.CSharpFunctionDelegate;
#else
using LuaAPI = XLua.LuaDLL.Lua;
using RealStatePtr = System.IntPtr;
using LuaCSFunction = XLua.LuaDLL.lua_CSFunction;
#endif

using XLua;
using System.Collections.Generic;


namespace XLua.CSObjectWrap
{
    using Utils = XLua.Utils;
    public class XHSlotScrollSlotScrollWrap 
    {
        public static void __Register(RealStatePtr L)
        {
			ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			System.Type type = typeof(XH.SlotScroll.SlotScroll);
			Utils.BeginObjectRegister(type, L, translator, 0, 3, 2, 2);
			
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "SetData", _m_SetData);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Scroll", _m_Scroll);
			Utils.RegisterFunc(L, Utils.METHOD_IDX, "Clear", _m_Clear);
			
			
			Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnRollEnd", _g_get_OnRollEnd);
            Utils.RegisterFunc(L, Utils.GETTER_IDX, "OnEnableGrid", _g_get_OnEnableGrid);
            
			Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnRollEnd", _s_set_OnRollEnd);
            Utils.RegisterFunc(L, Utils.SETTER_IDX, "OnEnableGrid", _s_set_OnEnableGrid);
            
			
			Utils.EndObjectRegister(type, L, translator, null, null,
			    null, null, null);

		    Utils.BeginClassRegister(type, L, __CreateInstance, 1, 0, 0);
			
			
            
			
			
			
			Utils.EndClassRegister(type, L, translator);
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int __CreateInstance(RealStatePtr L)
        {
            
			try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
				if(LuaAPI.lua_gettop(L) == 1)
				{
					
					XH.SlotScroll.SlotScroll __cl_gen_ret = new XH.SlotScroll.SlotScroll();
					translator.Push(L, __cl_gen_ret);
                    
					return 1;
				}
				
			}
			catch(System.Exception __gen_e) {
				return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
			}
            return LuaAPI.luaL_error(L, "invalid arguments to XH.SlotScroll.SlotScroll constructor!");
            
        }
        
		
        
		
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_SetData(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XH.SlotScroll.SlotScroll __cl_gen_to_be_invoked = (XH.SlotScroll.SlotScroll)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int count = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.SetData( count );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Scroll(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XH.SlotScroll.SlotScroll __cl_gen_to_be_invoked = (XH.SlotScroll.SlotScroll)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    int index = LuaAPI.xlua_tointeger(L, 2);
                    
                    __cl_gen_to_be_invoked.Scroll( index );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _m_Clear(RealStatePtr L)
        {
		    try {
            
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
            
            
                XH.SlotScroll.SlotScroll __cl_gen_to_be_invoked = (XH.SlotScroll.SlotScroll)translator.FastGetCSObj(L, 1);
            
            
                
                {
                    
                    __cl_gen_to_be_invoked.Clear(  );
                    
                    
                    
                    return 0;
                }
                
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            
        }
        
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnRollEnd(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XH.SlotScroll.SlotScroll __cl_gen_to_be_invoked = (XH.SlotScroll.SlotScroll)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.OnRollEnd);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _g_get_OnEnableGrid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XH.SlotScroll.SlotScroll __cl_gen_to_be_invoked = (XH.SlotScroll.SlotScroll)translator.FastGetCSObj(L, 1);
                translator.Push(L, __cl_gen_to_be_invoked.OnEnableGrid);
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 1;
        }
        
        
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnRollEnd(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XH.SlotScroll.SlotScroll __cl_gen_to_be_invoked = (XH.SlotScroll.SlotScroll)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.OnRollEnd = translator.GetDelegate<System.Action>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
        [MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
        static int _s_set_OnEnableGrid(RealStatePtr L)
        {
		    try {
                ObjectTranslator translator = ObjectTranslatorPool.Instance.Find(L);
			
                XH.SlotScroll.SlotScroll __cl_gen_to_be_invoked = (XH.SlotScroll.SlotScroll)translator.FastGetCSObj(L, 1);
                __cl_gen_to_be_invoked.OnEnableGrid = translator.GetDelegate<System.Action<int, JW.PLink.PrefabLink>>(L, 2);
            
            } catch(System.Exception __gen_e) {
                return LuaAPI.luaL_error(L, "c# exception:" + __gen_e);
            }
            return 0;
        }
        
		
		
		
		
    }
}
