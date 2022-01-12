using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{

    public float damage = 100.0f;
    public float lifetime = 2.0f;

    void OnEnable()
    {
        CancelInvoke();
        Invoke("Die", lifetime);
    }


    void OnTriggerEnter(Collider col)
    {
        Health health = col.gameObject.GetComponent<Health>();

        if (health == null)
            return;

        health.healthPoints -= damage;
    }


    void Die()
    {
        gameObject.SetActive(false);
    }
}
