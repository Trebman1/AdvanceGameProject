using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLocomotion : MonoBehaviour
{
    public Health health;
    NavMeshAgent agent;
    public Transform player; 
    Animator animator;
    public float maxTime = 1f;
    public float maxDistance = 1f;
    float timer = 0f;

    public LayerMask whatIsPlayer;
    public float sightRange, attackRange;
    public bool playerInSight, playerInAttack;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        playerInSight = Physics.CheckSphere(transform.position, sightRange, whatIsPlayer);
        playerInAttack = Physics.CheckSphere(transform.position, attackRange, whatIsPlayer);
        if(health.currHealth > 0){
            if(playerInSight && !playerInAttack) chase();
            if(playerInSight && playerInAttack){ attack();} else {animator.SetBool("isAttack", false);}
        
            animator.SetFloat("Speed", agent.velocity.magnitude);
        }
        
    }
    public void chase(){
        timer -= Time.deltaTime;
        if(timer < 0.0f){
            float sqrDistance = (player.position - agent.destination).sqrMagnitude;
            if(sqrDistance > maxDistance*maxDistance){
                agent.SetDestination(player.position);
            }
        }
        animator.SetFloat("Speed", agent.velocity.magnitude);
    }

    public void attack(){
        agent.SetDestination(transform.position);
        transform.LookAt(player);

        animator.SetBool("isAttack", true);
    }
}
