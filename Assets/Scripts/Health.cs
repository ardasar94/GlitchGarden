using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] int health = 100;

    [SerializeField] GameObject deathVfx;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void DealDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if (!deathVfx)
        {
            return;
        }
        GameObject deathVFXObject = Instantiate(deathVfx, transform.position, transform.rotation);
        Destroy(deathVFXObject, 1f);
    }

    public int GetHealth() { return health; }
}
