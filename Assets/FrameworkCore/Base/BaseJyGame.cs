using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JyFramework
{

    public class BaseJyGame
    {
        /*
         * 游戏框架的核心抽象类
         * 包括了：资源加载、UI、数据、网络、对象池、脚本、声音、时间、线程、工具、这些模块
         */

        public string Name { get { return _name; } }
        public EventController EventCtrl { get { return _eventCtrl; } }

        // UI模块
        public UIModule UIModule { get { return _moduleCtrl.UIModule; } }
        // 日志模块
        public LogModule LogModule { get { return _moduleCtrl.LogModule; } }
        // 时间模块
        public TimeModule TimeModule { get { return _moduleCtrl.TimeModule; } }
        // 数据模块(数据库的读写)
        public DataModule DataModule { get { return _moduleCtrl.DataModule; } }
        // 资源模块
        public ResourceModule ResModule { get { return _moduleCtrl.ResModule; } }
        // 声音模块
        public AudioModule AudioModule { get { return _moduleCtrl.AudioModule; } }
        // 线程模块
        public ThreadModule ThreadModule { get { return _moduleCtrl.ThreadModule; } }
        // 对象管理模块
        public ObjectModule ObjectModule { get { return _moduleCtrl.ObjectModule; } }
        // 脚本模块
        public ScriptModule ScriptModule { get { return _moduleCtrl.ScriptModule; } }
        // 网络模块
        public NetworkModule NetworkModule { get { return _moduleCtrl.NetworkModule; } }        

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="name"> 游戏名 </param>
        public BaseJyGame(string name = "BaseJyGame")
        {
            _name = name;
            _eventCtrl = new EventController();
            _moduleCtrl = new BaseModuleController();
            _moduleCtrl.InstanceModules(_eventCtrl);

            Debug.Log("BaseJyGame Ctor");
        }

        /// <summary>
        /// 发送开始游戏模块命令
        /// </summary>
        public void StartAllModule()
        {
            EventCtrl.NotifyEvent(EventConst.StartModule);
            Debug.Log("BaseJyGame StartAllModule");
        }

        public void NotifyUpdate(float deltaTime)
        {
            EventCtrl.NotifyEvent(EventConst.UpdateModule, deltaTime);
            Debug.Log("BaseJyGame NotifyUpdate");
        }

        public void RemoveAllModule()
        {
            EventCtrl.NotifyEvent(EventConst.ExitGame);
        }

        
        protected string _name;
        protected EventController _eventCtrl;
        protected BaseModuleController _moduleCtrl;        
    }
}