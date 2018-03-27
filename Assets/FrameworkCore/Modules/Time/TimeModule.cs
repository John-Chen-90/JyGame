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

        public override void Init()
        {
            base.Init();
            _updateEvent = (UpdateEvent)CreateEvent<UpdateEvent>();
            RegistEvent(EventConst.UpdateModule, _updateEvent);
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
