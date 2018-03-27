using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFramework
{
    public class BaseModuleController
    {
        // 资源模块
        public ResourceModule ResModule;
        // UI模块
        public UIModule UIModule;
        // 数据模块(数据库的读写)
        public DataModule DataModule;
        // 网络模块
        public NetworkModule NetworkModule;
        // 脚本模块
        public ScriptModule ScriptModule;
        // 声音模块
        public AudioModule AudioModule;
        // 对象管理模块
        public ObjectModule ObjectModule;
        // 时间模块
        public TimeModule TimeModule;
        // 线程模块
        public ThreadModule ThreadModule;

        /// <summary>
        /// 实例化并且初始化模块
        /// </summary>
        /// <param name="eventCtrl"></param>
        public void InstanceModules(EventController eventCtrl)
        {
            UIModule = BaseGameFactory.CreateModule<UIModule>(eventCtrl);
            DataModule = BaseGameFactory.CreateModule<DataModule>(eventCtrl);
            TimeModule = BaseGameFactory.CreateModule<TimeModule>(eventCtrl);
            AudioModule = BaseGameFactory.CreateModule<AudioModule>(eventCtrl);
            ResModule = BaseGameFactory.CreateModule<ResourceModule>(eventCtrl);
            ObjectModule = BaseGameFactory.CreateModule<ObjectModule>(eventCtrl);
            ScriptModule = BaseGameFactory.CreateModule<ScriptModule>(eventCtrl);
            ThreadModule = BaseGameFactory.CreateModule<ThreadModule>(eventCtrl);
            NetworkModule = BaseGameFactory.CreateModule<NetworkModule>(eventCtrl);
        }
    }
}
