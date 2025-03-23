using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NodeCanvas.Framework;
using ParadoxNotion.Serialization.FullSerializer;
public class CookedCT : ConditionTask
{
    public BBParameter<GameObject> frenchFryObj;
    FrenchFry frenchFryScript;
    protected override bool OnCheck()
    {
        if(frenchFryObj.value.gameObject.GetComponent<FrenchFry>() != null)
        {
            frenchFryScript = frenchFryObj.value.gameObject.GetComponent<FrenchFry>();
            //Debug.Log(frenchFryScript.cooked);
            return frenchFryScript.cooked;
        }
        else { return false; };
    }
}
