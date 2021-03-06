﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class NetworkModule : BaseModule
    {
        public NetworkModule(EventController ec, string name = "NetworkModule") : base(ec, name)
        {
        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("NetworkModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("NetworkModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("NetworkModule OnExit");
        }
    }
}
