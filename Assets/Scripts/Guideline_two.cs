using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Guideline_two : MonoBehaviour
{
    [SerializeField] GameObject pressButton;
    [SerializeField] GameObject tutorialSmall;
    void OnTriggerEnter(Collider tutorial)
    {
        if (tutorial.tag == "weapon")
        {
            pressButton.SetActive(true);


        }
    }

    void OnTriggerExit(Collider tutorial)
    {
        if (tutorial.tag == "weapon")
        {
            pressButton.SetActive(false);
            tutorialSmall.SetActive(false);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            tutorialSmall.SetActive(true);
        }

    }
}
