﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float speed = 1f;

    [SerializeField] int damage = 50;

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * speed);
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {

        var health = collision.GetComponent<Health>();
        var attacker = collision.GetComponent<Attacker>();

        if (attacker && health)
        {
            health.DealDamage(damage);
            Destroy(gameObject);

        }
    }

}
