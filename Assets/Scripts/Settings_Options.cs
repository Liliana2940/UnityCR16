using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settings_Options : MonoBehaviour
{

    [SerializeField] private AudioMixer audioMixer;

    public void PantallaCompleta(bool pantallaComp)
    {
        Screen.fullScreen = pantallaComp;
    }

    public void controlVolume(float volumen)
    {
        audioMixer.SetFloat("Volumen", volumen);
    }
}
