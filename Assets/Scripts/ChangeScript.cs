using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScript : MonoBehaviour
{
    public EnemyScript enemy;
    public float changeX = 0;
    public float changeY = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            enemy = collision.GetComponent<EnemyScript>();
            enemy.moveX = changeX;
            enemy.moveY = changeY;
        }
    }
}
