using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGame : MonoBehaviour
{
    public void toPlay()
    {
        SceneManager.LoadScene(1);
    }

    public void goToDesktop()
    {
        Application.Quit();
    }
}
