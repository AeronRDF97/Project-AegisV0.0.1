using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guideline : MonoBehaviour
{

    [SerializeField] GameObject pressButton;
    [SerializeField] GameObject tutorialMid;
    void OnTriggerEnter(Collider tutorial)
    {
        if(tutorial.tag == "weapon")
        {
            pressButton.SetActive(true);
            if (Input.GetKeyDown(KeyCode.Q))
            {
                tutorialMid.SetActive(true);
            }

        }
    }

    void OnTriggerExit(Collider tutorial)
    {
        if (tutorial.tag == "weapon")
        {
            pressButton.SetActive(false);
            tutorialMid.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            tutorialMid.SetActive(true);
        }

    }
}
