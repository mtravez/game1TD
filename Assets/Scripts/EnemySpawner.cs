using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy0;
    private float timer = 0;
    public float spawnRate = 2;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnEnemyZero();
            timer = 0;
        }
    }

    void spawnEnemyZero()
    {
        Instantiate(enemy0, transform.position, transform.rotation);
    }
}
