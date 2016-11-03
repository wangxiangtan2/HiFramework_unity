﻿//*********************************************************************
// Description:
// Author: hiramtan@live.com
//*********************************************************************
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using HiFramework;

public class NewBehaviourScript : MonoBehaviour
{


    // Use this for initialization
    void Start()
    {

        new GameObject("GameTick").AddComponent<GameWorld>();


        var tt = Facade.AgentFactory.Register<tt>("12345");


        tt test = Facade.AgentFactory.GetAgent(typeof(tt).FullName) as tt;

        test.Log();


        Facade.Dispose();

    }

    // Update is called once per frame
    void Update()
    {

    }
}

public class tt : Agent
{
    public void Log()
    {
        Debug.Log("from tt");


    }

    public override void OnTick()
    {
        throw new System.NotImplementedException();
    }

    public override void OnMessage(Message paramMessage)
    {
        Debug.Log("from message");
        // throw new System.NotImplementedException();
    }
}