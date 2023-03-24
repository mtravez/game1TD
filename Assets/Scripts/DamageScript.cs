using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageScript : MonoBehaviour
{
    public Health enemyHealth;
    public float interval = 2;
    private float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer >= interval && enemyHealth)
        {
            enemyHealth.takeDamage();
            timer = 0;
        }
        else if (enemyHealth)
        {
            timer += Time.deltaTime;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            enemyHealth = collision.GetComponent<Health>();
            enemyHealth.takeDamage();
            timer = 0;
        }
    }

}
