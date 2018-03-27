using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class ThreadModule : BaseModule
    {
        public ThreadModule(EventController ec, string name = "ThreadModule") : base(ec, name)
        {
        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("ThreadModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("ThreadModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("ThreadModule OnExit");
        }
    }
}
