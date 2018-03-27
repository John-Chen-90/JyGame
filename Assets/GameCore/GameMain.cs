using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JyFramework;

namespace GameCore
{
    public class GameMain : MonoBehaviour
    {
        private static GameMain _ins;
        public static GameMain Ins { get { return _ins; } }

        public JyApp App;

        void Awake()
        {
            App = new JyApp("JyGame");
            App.Init();

            _ins = GetComponent<GameMain>();
        }

        void Start()
        {
            App.StartAllModule();
        }

        void Update()
        {
            App.NotifyUpdate(Time.deltaTime);
        }
    }
}