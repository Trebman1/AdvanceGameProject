using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Hitbox : MonoBehaviour
{
    public Player_Health health;
    public float damage = 3;

    public void OnTriggerEnter(Collider other){
        if(other.CompareTag("ESword")){
            health.TakeDamage(damage);
        }
    }
}
