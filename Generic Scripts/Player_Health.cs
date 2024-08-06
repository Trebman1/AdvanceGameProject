using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Health : MonoBehaviour
{
    public float maxHealth;
    public float currHealth;
    RagDoll ragdoll;
    UIHealthbar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        currHealth = maxHealth;
        ragdoll = GetComponent<RagDoll>();
        healthbar = GetComponentInChildren<UIHealthbar>();

        var rigidbodies = GetComponentsInChildren<Rigidbody>();
        foreach(var rigidbody in rigidbodies){
            Player_Hitbox hitbox = rigidbody.gameObject.AddComponent<Player_Hitbox>();
            hitbox.health = this;
        }
    }

    // Update is called once per frame
    public void TakeDamage(float amount){
        currHealth -= amount;
        healthbar.ShowHealthBarPercentage(currHealth / maxHealth);
        if(currHealth <= 0f){
            Die();
        }
    }

    public void Die(){
        ragdoll.ActivateRagdoll();
    }
}
