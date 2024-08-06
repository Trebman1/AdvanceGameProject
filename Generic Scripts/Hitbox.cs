using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitbox : MonoBehaviour
{
    public Health health;
    public float damage = 10;

    public void OnTriggerEnter(Collider other){
        if(other.CompareTag("PSword")){
            health.TakeDamage(damage);
        }
    }
}
