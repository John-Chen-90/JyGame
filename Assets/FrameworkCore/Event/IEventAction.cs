using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFramework
{
    public interface IEventAction
    {
        void ExecuteEvent(params object[] parms);
    }
}
