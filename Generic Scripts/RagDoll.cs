using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDoll : MonoBehaviour
{
    Rigidbody[] rigidbodies;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbodies = GetComponentsInChildren<Rigidbody>();
        animator = GetComponent<Animator>();
        DeactivateRagdoll();
    }

    public void DeactivateRagdoll(){
        foreach(var rigidBody in rigidbodies){
            rigidBody.isKinematic = true;
        }
        animator.enabled = true;
    }
    public void ActivateRagdoll(){
        foreach(var rigidBody in rigidbodies){
            rigidBody.isKinematic = false;
        }
        animator.enabled = false;
    }
}
