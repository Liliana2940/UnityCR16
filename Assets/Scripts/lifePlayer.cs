using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class lifePlayer : MonoBehaviour
{
    [SerializeField] private float vida;
    [SerializeField] private float maximoVida;
    [SerializeField] private BarraDeVida barraDeVida;

    public event EventHandler PlayerDead;

    // Start is called before the first frame update
    void Start()
    {
        vida = maximoVida;
        barraDeVida.InicializarBarraDeVida(vida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            vida--;
            barraDeVida.CambiarVidaActual(vida);
            if (vida <= 0)
            {
                PlayerDead?.Invoke(this, EventArgs.Empty);
                Destroy(gameObject);
            }
        }
    }
}
