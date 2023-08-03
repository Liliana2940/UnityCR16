using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    private float puntos;
    private TextMeshProUGUI textMesh;

    // Start is called before the first frame update
    private void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    private void Update()
    {
        puntos += Time.deltaTime;
        textMesh.text = puntos.ToString("0");
    }

    public void SumaPuntos(float puntosEntrada)
    {
        puntos += puntosEntrada;
    }
}
