using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;
    private bool pausedGame = false;

    private void Update() 
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(pausedGame){
                Resume();
            } else{
                Pausa();
            }
        }    
    }

    public void Pausa()
    {
        pausedGame = true;
        Time.timeScale = 0f;
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    public void Resume()
    {
        pausedGame = false;
        Time.timeScale = 1f;
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    public void Restart()
    {
        pausedGame = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Quit () 
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
