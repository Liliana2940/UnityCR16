using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler2 : MonoBehaviour
{
    [SerializeField] private GameObject bulletMovePrefab;
    [SerializeField] private Transform firingPoint;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("up") || Input.GetKey("w"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,5500f * Time.deltaTime));
            
        }        if(Input.GetKey("down") || Input.GetKey("s"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0,-5500f * Time.deltaTime));
            
        }
        if(Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    [SerializeField] private AudioClip disparo;

    private void Shoot() 
    {
        Instantiate(bulletMovePrefab, firingPoint.position, firingPoint.rotation);
        controladorSonido.Instance.EjecutarSonido(disparo);
    }
}
