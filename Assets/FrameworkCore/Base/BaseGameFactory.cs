using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFramework
{
    /// <summary>
    /// 框架的工厂,生成各种模块的实例
    /// </summary>
    public class BaseGameFactory
    {
        public static T CreateModule<T>(EventController eventCtrl) where T : BaseModule
        {
            BaseModule module = (T)new BaseModule(eventCtrl);            
            return (T)module;
        }

    }
}
