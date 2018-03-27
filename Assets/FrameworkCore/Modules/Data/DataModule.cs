using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace JyFramework
{
    public class DataModule : BaseModule
    {
        public DataModule(EventController ec, string name = "DataModule") : base(ec, name)
        {
        }

        protected override void OnStart(params object[] parms)
        {
            Debug.Log("DataModule OnStart");
        }

        protected override void OnPause(params object[] parms)
        {
            Debug.Log("DataModule OnPause");
        }

        protected override void OnExit(params object[] parms)
        {
            Debug.Log("DataModule OnExit");
        }
    }
}
