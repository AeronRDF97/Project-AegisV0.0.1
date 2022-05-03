using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerhealth : MonoBehaviour
{
    public float hits = 0;
    [SerializeField] GameObject gameOver;


    void OnTriggerEnter(Collider damage)
    {

        if (damage.tag == "weapon")
        {
            hits++;
            if (hits == 3)
            {
                gameObject.SetActive(false);
                gameOver.SetActive(true); 
            }
            //Destroy(gameObject);
            //gameObject.SetActive(false);
        }
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }
}


