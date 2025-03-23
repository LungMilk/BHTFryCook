using NodeCanvas.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EatingAT : ActionTask
{
    public BBParameter<GameObject> frenchFryObj;
    FrenchFry frenchFryScript;
    protected override string OnInit()
    {
        if (frenchFryObj.value.gameObject.GetComponent<FrenchFry>() != null)
        {
            frenchFryScript = frenchFryObj.value.gameObject.GetComponent<FrenchFry>();
        }
        return null;
    }
    protected override void OnExecute()
    {
        Debug.Log($"{frenchFryScript.cooked}");
        frenchFryScript.cooked = !frenchFryScript.cooked;
    }

}
