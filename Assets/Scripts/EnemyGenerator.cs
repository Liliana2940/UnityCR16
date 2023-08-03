using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject EnemyMed;
    [SerializeField] private float secondsWait;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine (startTimer());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator startTimer()
    {
        yield return new WaitForSeconds(secondsWait);
        UnityEngine.Vector2 position = new Vector2 (Random.Range(101,140), Random.Range(-50,50));
        GameObject newEnemy = Instantiate(EnemyMed, position, EnemyMed.transform.rotation);
        StartCoroutine (startTimer());
    }
}
