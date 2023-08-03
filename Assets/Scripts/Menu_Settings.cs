using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu_Settings : MonoBehaviour
{
    [SerializeField] private GameObject menuSettings;
    [SerializeField] private GameObject botonQuit;

    public void Ajustes()
    {
        menuSettings.SetActive(true);
    }

    public void quitSettings()
    {
        menuSettings.SetActive(false);
    }
}
