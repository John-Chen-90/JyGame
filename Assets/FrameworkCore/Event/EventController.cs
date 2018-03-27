using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace JyFramework
{
    public class EventController
    {
        // 当前类中的所有事件
        protected Dictionary<string, List<IEventAction>> _events = null;

        public EventController()
        {
            _events = new Dictionary<string, List<IEventAction>>();
        }

        /// <summary>
        /// 注册事件
        /// </summary>
        /// <param name="name"> 事件名 </param>
        /// <param name="action"> 事件接口实现的实例类 </param>
        public void RegistEvent(string name, IEventAction action)
        {
            List<IEventAction> actions = null;
            if (_events.TryGetValue(name, out actions))
            {
                actions.Add(action);
            }
            else
            {
                actions = new List<IEventAction>();
                actions.Add(action);
                _events.Add(name, actions);
            }
        }

        /// <summary>
        /// 移除事件
        /// </summary>
        /// <param name="name"> 事件名 </param>
        public void RemoveEvent(string name, IEventAction action)
        {
            List<IEventAction> actions = null;
            if (_events.TryGetValue(name, out actions))
            {
                if (actions.Contains(action))
                    actions.Remove(action);
                else
                {
                    // 输出当前事件未被注册
                }
            }
            else
            {
                // 输出无当前事件注册信息
            }
        }

        /// <summary>
        /// 通知事件
        /// </summary>
        /// <param name="name"> 事件名 </param>
        /// <param name="parms"> 事件参数 </param>
        public void NotifyEvent(string name, params object[] parms)
        {
            List<IEventAction> actions = null;
            if(_events.TryGetValue(name, out actions))
            {
                foreach(var a in actions)
                {
                    a.ExecuteEvent(parms);
                }
            }
            else
            {
                // 输出警告
            }
        }
    }

}