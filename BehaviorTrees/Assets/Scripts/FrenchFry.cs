using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class FrenchFry : MonoBehaviour
{
    public bool cooked = false;
    Renderer render;

    private void Start()
    {
        render = this.gameObject.GetComponent<Renderer>();
        render.material.color = Color.white;
    }

    private void Update()
    {
        if (cooked)
        {
            render.material.color = Color.yellow;
        }
        else { render.material.color = Color.white;}
    }
}
