using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JyFramework
{
    public class JyApp : BaseJyGame
    {
        public JyApp(string name = "JyGame"):base(name)
        {
            Debug.Log("JyApp Ctor");
        }
    }
}