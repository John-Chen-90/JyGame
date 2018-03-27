using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class ResourceModule : BaseModule
    {
        public ResourceModule(EventController ec, string name = "ResourceModule") : base(ec, name)
        {
        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("ResourceModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("ResourceModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("ResourceModule OnExit");
        }

        public void LoadRes(string path)
        {

        }
    }
}
