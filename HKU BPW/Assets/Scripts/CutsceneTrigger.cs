using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutsceneTrigger : MonoBehaviour
{
    public GameManager GameManager;

    private void OnCollisionEnter(Collision Collision)
    {
        if (Collision.gameObject.tag == "Player")
        {
            Debug.Log("Trigger Hit!"); //om te kijken of de collision ook echt gedetecteerd wordt.
            GameManager.TriggerCutscene();
        }

        
    }
}
