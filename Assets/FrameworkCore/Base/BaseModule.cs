using JyFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class BaseModule : EventController
    {
        /// <summary>
        /// 当前模块名
        /// </summary>
        protected string _name;
        /// <summary>
        /// 当前模块持有的EventCtrl
        /// </summary>
        protected EventController _eventCtrl;
        /// <summary>
        /// 注册开始事件
        /// </summary>
        protected StartEvent _startEvent;

        /// <summary>
        /// 注册暂停事件
        /// </summary>
        protected PauseEvent _pauseEvent;

        /// <summary>
        /// 退出游戏事件
        /// </summary>
        protected ExitEvent _exitEvent;

        /// <summary>
        /// 开始模块时需要执行的函数
        /// </summary>
        /// <param name="parms"></param>
        protected virtual void OnStart(params object[] parms)
        {
            Debug.Log("BaseModule OnStart");
        }

        /// <summary>
        /// 暂停游戏时需要执行的函数
        /// </summary>
        /// <param name="parms"></param>
        protected virtual void OnPause(params object[] parms)
        {
            Debug.Log("BaseModule OnPause");
        }

        /// <summary>
        /// 退出游戏时需要执行的事件
        /// </summary>
        /// <param name="parms"></param>
        protected virtual void OnExit(params object[] parms)
        {
            RemoveModule();

            Debug.Log("BaseModule OnExit");
        }

        /// <summary>
        /// 当前模块得到通知需要执行的事件
        /// </summary>
        /// <param name="parms"> 执行事件参数 </param>
        protected class StartEvent : IEventAction
        {
            protected BaseModule _module;
            public StartEvent(BaseModule module)
            {
                _module = module;
            }

            public void ExecuteEvent(params object[] parms)
            {
                _module.OnStart(parms);
            }
        }

        protected class PauseEvent : IEventAction
        {
            protected BaseModule _module;
            public PauseEvent(BaseModule module)
            {
                _module = module;
            }

            public void ExecuteEvent(params object[] parms)
            {
                _module.OnPause(parms);
            }
        }

        protected class ExitEvent : IEventAction
        {
            protected BaseModule _module;

            public ExitEvent(BaseModule module)
            {
                _module = module;
            }

            public void ExecuteEvent(params object[] parms)
            {
                _module.OnExit(parms);
            }
        }


        public string Name { get { return _name; } }
        public EventController EventCtrl { get { return _eventCtrl; } }

        /// <summary>
        /// 构造方法
        /// </summary>
        /// <param name="ec"> 外部传入的eventctrl </param>
        public BaseModule(EventController ec, string name = "BaseModule")
        {
            _name = name;
            _startEvent = new StartEvent(this);
            _pauseEvent = new PauseEvent(this);
            _exitEvent = new ExitEvent(this);

            _eventCtrl = ec;
            RegistModule();
        }

        /// <summary>
        /// 注册本模块
        /// </summary>
        public void RegistModule()
        {
            _eventCtrl.RegistEvent(EventConst.StartModule, _startEvent);
            _eventCtrl.RegistEvent(EventConst.PauseModule, _pauseEvent);
            _eventCtrl.RegistEvent(EventConst.ExitGame, _exitEvent);
        }

        /// <summary>
        /// 移除本模块
        /// </summary>
        public void RemoveModule()
        {
            _eventCtrl.RemoveEvent(EventConst.StartModule, _startEvent);
            _eventCtrl.RemoveEvent(EventConst.PauseModule, _pauseEvent);
            _eventCtrl.RemoveEvent(EventConst.ExitGame, _exitEvent);
        }

    }

}