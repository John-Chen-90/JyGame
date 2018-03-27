using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class TimeModule : BaseModule
    {
        public TimeModule(EventController ec, string name = "TimeModule") : base(ec, name)
        {

        }     

        protected override void OnStart(params object[] parms)
        {
            _updateEvent = new UpdateEvent(this);
            _eventCtrl.RegistEvent(EventConst.UpdateModule, _updateEvent);

            Debug.Log("TimeModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("TimeModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("TimeModule OnExit");
        }

        protected virtual void OnUpdate(params object[] parms)
        {
            Debug.Log("TimeModule OnUpdate");
        }

        protected UpdateEvent _updateEvent;

        protected class UpdateEvent : IEventAction
        {
            protected TimeModule _module;
            public UpdateEvent(TimeModule module)
            {
                _module = module;
            }

            public void ExecuteEvent(params object[] parms)
            {
                _module.OnUpdate(parms);
            }
        }
    }
}
