using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.Framework;
using UnityEngine.AI;
using ParadoxNotion.Serialization.FullSerializer;

public class MoveAT : ActionTask
{
    public NavMeshAgent navAgent;
    public BBParameter<Transform> destination;
    protected override string OnInit()
    {
        if (agent == null)
        {
            Debug.Log("Agent is null in MoveAT task!");
            return "Agent is null!";
        }

        navAgent = agent.gameObject.GetComponent<NavMeshAgent>();

        if (navAgent == null)
        {
            Debug.Log("NavMeshAgent not found on agent object!");
            return "NavMeshAgent not found!";
        }

        return null;
    }

    protected override void OnExecute()
    {
        Debug.Log(navAgent.gameObject.name);
        Debug.Log(destination.value);
        if(navAgent != null) { navAgent.SetDestination(destination.value.position); }
        //base.OnExecute();
    }
}
