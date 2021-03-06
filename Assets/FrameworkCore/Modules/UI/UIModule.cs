﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class UIModule : BaseModule
    {
        public UIModule(EventController ec, string name = "UIModule") : base(ec, name)
        {

        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("UIModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("UIModule OnStart");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("UIModule OnExit");
        }
    }
}
