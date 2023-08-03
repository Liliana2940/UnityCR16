using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class menuGameOver : MonoBehaviour
{

    [SerializeField] private GameObject gameOverMenu;
    private lifePlayer refLifePlayer;

    private void Start()
    {
        refLifePlayer = GameObject.FindGameObjectWithTag("Player").GetComponent<lifePlayer>();
        refLifePlayer.PlayerDead += ActivateMenu;
    }

    [SerializeField] private AudioClip sonidoOver;

    private void ActivateMenu(object sender, EventArgs e)
    {
        gameOverMenu.SetActive(true);
        controladorSonido.Instance.EjecutarSonido(sonidoOver);
        Time.timeScale = 0f;
    }

    public void restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void mainMenu(string nombre)
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(nombre);
    }

    public void quitar()
    {
        Application.Quit();
    }
}
