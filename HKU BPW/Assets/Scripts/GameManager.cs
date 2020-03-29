using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool cutSceneHasTriggered = false;

    public GameObject CutsceneTimeline;

    public void TriggerCutscene()
    {
        CutsceneTimeline.SetActive(true);
    }
}
