﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerColorSwitch1 : MonoBehaviour
{

    public GameObject Tower;
    public Material material1;

    private void OnCollisionEnter(Collision Collision)
    {
        //als de player collide met het switch object, dan word de boolean colorTrigger of 'true' gezet. 

        if (Collision.gameObject.tag == "Player")
        {
            Debug.Log("Trigger Hit!"); //om te kijken of de collision ook echt gedetecteerd wordt.

            Tower.GetComponent<Renderer>().material = material1;
            //Material Swap? 1. public Material newMaterialRef;, 2. renderer.material = newMaterialRef;
        }

    }
}
