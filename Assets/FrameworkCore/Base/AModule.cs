using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public abstract class  AModule
{
    protected string _name;
    public string Name { get; }

    // 注册本模块到主框架
    public abstract void RegistModule();

    // 从主框架移除本模块
    public abstract void RemoveModule();
   
}

