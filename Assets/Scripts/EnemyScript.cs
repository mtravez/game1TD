using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float moveX = 0;
    public float moveY = -5;
    public float moveSpeed = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (new Vector3(moveX, moveY, 0) * moveSpeed) * Time.deltaTime;
    }
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
