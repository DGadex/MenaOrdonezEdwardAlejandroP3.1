using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{

    public float damagePoints = 10.0f;


    void OnTriggerStay(Collider otherCollider)
    {
        Health health = otherCollider.gameObject.GetComponent<Health>();

        if (health == null)
            return;

        health.healthPoints -= damagePoints * Time.deltaTime;
    }
}
