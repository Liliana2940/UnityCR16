using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    [Range(1,10)]
    [SerializeField] private float lifetime = 5f;

    private Rigidbody2D rb;

    private void Start() 
    {
        Destroy(gameObject, lifetime);
    }

    private void FixedUpdate() 
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(90f,0));
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
    
}
