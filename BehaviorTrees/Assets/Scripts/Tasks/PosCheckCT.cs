using NodeCanvas.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosCheckCT : ConditionTask
{
    public Transform objectA;
    public BBParameter<Transform> objectB;
    public BBParameter<float> threshold;

    protected override bool OnCheck()
    {
        objectA = agent.gameObject.GetComponent<Transform>();
        return CheckPos(objectA.position, objectB.value.position);
    }

    bool CheckPos(Vector3 pos1, Vector3 pos2)
    {
        if (Vector3.Distance(pos1, pos2) <= threshold.value) return true;
        else return false;
    }
}
