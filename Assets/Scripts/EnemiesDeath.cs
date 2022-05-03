using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesDeath : MonoBehaviour
{

    public float hits = 0; 
    void OnTriggerEnter(Collider other)
    {

        if (other.tag == "weapon")
        {
            hits++;
            if(hits == 3)
            {
                gameObject.SetActive(false);
            }
            //Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }
}
