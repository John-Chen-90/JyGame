using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class ObjectModule : BaseModule
    {
        public ObjectModule(EventController ec, string name = "ObjectModule") : base(ec, name)
        {
        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("ObjectModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("ObjectModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("ObjectModule OnExit");
        }
    }
}
