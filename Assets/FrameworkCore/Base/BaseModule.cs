using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


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
            
        }

        /// <summary>
        /// 暂停游戏时需要执行的函数
        /// </summary>
        /// <param name="parms"></param>
        protected virtual void OnPause(params object[] parms)
        {

        }

        /// <summary>
        /// 退出游戏时需要执行的事件
        /// </summary>
        /// <param name="parms"></param>
        protected virtual void OnExit(params object[] parms)
        {
            RemoveModule();
        }

        /// <summary>
        /// 创建事件
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        protected BaseEventAction CreateEvent<T>() where T : BaseEventAction
        {
            BaseEventAction bea = new BaseEventAction(this);
            return (T)bea;
        }

        /// <summary>
        /// 当前模块得到通知需要执行的事件
        /// </summary>
        /// <param name="parms"> 执行事件参数 </param>
        protected class StartEvent : BaseEventAction
        {
            protected StartEvent(BaseModule module) : base(module)
            {

            }

            public override void ExecuteEvent(params object[] parms)
            {
                _module.OnStart(parms);
            }
        }

        protected class PauseEvent : BaseEventAction
        {
            public PauseEvent(BaseModule module) : base(module)
            {
            }

            public override void ExecuteEvent(params object[] parms)
            {
                _module.OnPause(parms);
            }
        }

        protected class ExitEvent : BaseEventAction
        {
            public ExitEvent(BaseModule module) : base(module)
            {
            }

            public override void ExecuteEvent(params object[] parms)
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
            _startEvent = (StartEvent)CreateEvent<StartEvent>();
            _pauseEvent = (PauseEvent)CreateEvent<PauseEvent>();
            _exitEvent = (ExitEvent)CreateEvent<ExitEvent>();

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