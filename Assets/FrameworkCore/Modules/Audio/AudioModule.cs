using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class AudioModule : BaseModule
    {
        public AudioModule(EventController ec, string name = "AudioModule") : base(ec, name)
        {
        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("AudioModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("AudioModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("AudioModule OnExit");
        }
    }
}
