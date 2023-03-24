using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float max_health = 100;
    public GameObject enemy;
    public float health = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            GameObject.Destroy(enemy);
        }
    }
    [ContextMenu("Take damage")]
    public void takeDamage()
    {
        health -= 10;
        Debug.Log("Health left: " + health);
    }
}
