using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JyFramework
{
    public class ResourceModule : BaseModule
    {
        public ResourceModule(EventController ec, string name = "ResourceModule") : base(ec, name)
        {
        }

        public override void Init()
        {
            base.Init();

        }

        public void LoadRes(string path)
        {

        }
    }
}
