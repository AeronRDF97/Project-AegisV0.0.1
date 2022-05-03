using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLoader : MonoBehaviour
{

    [SerializeField] GameObject menuLoader;

    public void Campaing()
    {
        SceneManager.LoadScene("Campaing");
    }
    
    public void Training()
    {
        SceneManager.LoadScene("Training");

    }
    
    public void Settings()
    {

        Debug.Log("Settings");
    }

    public void QuitGame()
    {
        Application.Quit();

        Debug.Log("Quit");
    }
}
