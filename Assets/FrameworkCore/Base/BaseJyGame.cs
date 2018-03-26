using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseJyGame
{
    /*
     * 游戏框架的核心抽象类
     * 包括了：资源加载、UI、数据、网络、对象池、脚本、声音、时间、线程、工具、这些模块
     */

    // 资源模块
    public BaseModule ResModule;
    // UI模块
    public BaseModule UIModule;
    // 数据模块(数据库的读写)
    public BaseModule DataModule;
    // 网络模块
    public BaseModule NetworkModule;
    // 脚本模块
    public BaseModule ScriptModule;
    // 声音模块
    public BaseModule AudioModule;
    // 对象管理模块
    public BaseModule ObjectModule;
    // 时间模块
    public BaseModule TimeModule;
    // 线程模块
    public BaseModule ThreadModule;

    public void StartAllModule()
    {
        ResModule.RegistModule();
    }

}
