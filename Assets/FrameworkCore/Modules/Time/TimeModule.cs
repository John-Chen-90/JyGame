using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFramework
{
    public class TimeModule : BaseModule
    {
        public TimeModule(EventController ec, string name = "TimeModule") : base(ec, name)
        {

        }     

        protected override void OnStart(params object[] parms)
        {
            _updateEvent = (UpdateEvent)CreateEvent<UpdateEvent>();
            RegistEvent(EventConst.UpdateModule, _updateEvent);
        }

        protected override void OnPause(params object[] parms)
        {

        }

        protected override void OnExit(params object[] parms)
        {

        }


        protected UpdateEvent _updateEvent;

        protected class UpdateEvent : BaseEventAction
        {
            public UpdateEvent(BaseModule module):base(module)
            {

            }

            public override void ExecuteEvent(params object[] parms)
            {
                float deltaTime = (float)parms[0];

            }
        }
    }
}
