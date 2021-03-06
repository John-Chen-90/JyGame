﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class ScriptModule : BaseModule
    {
        public ScriptModule(EventController ec, string name = "ScriptModule") : base(ec, name)
        {
        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("ScriptModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("ScriptModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("ScriptModule OnExit");
        }
    }
}
