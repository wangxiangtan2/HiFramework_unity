﻿/****************************************************************************
* Description:
*
* Author: hiramtan @live.com
****************************************************************************/



using System.Collections;

namespace HiFramework
{
    public class PoolComponent : Component, IPoolComponent
    {
        private Hashtable t;

        public PoolComponent(IContainer iContainer) : base(iContainer)
        {
        }
        

        //public IPool<T> CreatePool<T>(string name, IPoolHandler iPoolHandler)
        //{
        //    if (!_pools.ContainsKey(name))
        //    {
        //        Assert.Exception("have no this pool:" + name);
        //        return null;
        //    }
        //    IPool<T> iPool = new Pool<T>(iPoolHandler);
        //    _pools.Add(name, iPool);
        //    return iPool;
        //}

        //public void DeletePool(string name)
        //{
        //    if (!_pools.ContainsKey(name))
        //    {
        //        Assert.Exception("have no this key:" + name);
        //        return;
        //    }
        //    _pools[name].Destory();
        //    _pools.Remove(name);
        //}

        public IPool<T> CreatePool<T>(IPoolHandler<T> iPoolHandler)
        {
            return new Pool<T>(iPoolHandler);
        }

        public void DeletePool<T>(IPool<T> iPool)
        {
            iPool.Destory();
            iPool = null;
        }

        public override void OnInit()
        {
        }

        public override void OnClose()
        {
        }
    }
}