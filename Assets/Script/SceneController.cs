using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneController : MonoBehaviour
{
    public void Home_Screen()
    {
        SceneManager.LoadScene("Home_Screen");
    }

    public void Liver_info()
    {
        SceneManager.LoadScene("Liver_info");
        
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
