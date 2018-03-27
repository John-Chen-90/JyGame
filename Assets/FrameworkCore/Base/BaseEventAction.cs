using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFramework
{
    public class BaseEventAction : IEventAction
    {
        protected BaseModule _module;

        public BaseEventAction(BaseModule module)
        {
            _module = module;
        }

        public virtual void ExecuteEvent(params object[] parms)
        {
            
        }
    }
}
