using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject otherCollider = collision.gameObject;
        if (otherCollider.GetComponent<Attacker>())
        {
            FindObjectOfType<LivesDisplay>().LooseLive();
            Destroy(collision.gameObject);
        }
    }
}
