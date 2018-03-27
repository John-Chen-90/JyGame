using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class LogModule : BaseModule
    {
        public LogModule(EventController ec, string name = "LogModule") : base(ec, name)
        {

        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("LogModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("LogModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("LogModule OnExit");
        }

    }
}
