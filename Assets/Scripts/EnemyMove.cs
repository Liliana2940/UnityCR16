using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    [SerializeField] private float lifetime = 3f;
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private float velocity;
    //[SerializeField] private Puntaje puntaje;
    private bool TriggerOn = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-velocity * Time.deltaTime, 0));
        Destroy(gameObject, lifetime);
    }

    // Destroy it!!!!

    [SerializeField] private AudioClip sonidoDestroy;

     void OnTriggerEnter2D(Collider2D other) 
    {
        if (TriggerOn)
        {
            if (other.CompareTag("Bullet") || other.CompareTag("Player"))
            {
                //puntaje.SumaPuntos(cantidadPuntos);
                Destroy(gameObject);
                controladorSonido.Instance.EjecutarSonido(sonidoDestroy);
            }
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.CompareTag("Control"))
        {
            TriggerOn = true;
        }    
    }
}
