using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

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
        // 日志模块
        public LogModule LogModule;

        /// <summary>
        /// 实例化并且初始化模块
        /// </summary>
        /// <param name="eventCtrl"></param>
        public void InstanceModules(EventController eventCtrl)
        {
            UIModule = new UIModule(eventCtrl);
            LogModule = new LogModule(eventCtrl);
            DataModule = new DataModule(eventCtrl);
            TimeModule = new TimeModule(eventCtrl);
            AudioModule = new AudioModule(eventCtrl);
            ResModule = new ResourceModule(eventCtrl);
            ObjectModule = new ObjectModule(eventCtrl);
            ScriptModule = new ScriptModule(eventCtrl);
            ThreadModule = new ThreadModule(eventCtrl);
            NetworkModule = new NetworkModule(eventCtrl);
            Debug.Log("BaseModuleController InstanceModules");
        }
    }
}
