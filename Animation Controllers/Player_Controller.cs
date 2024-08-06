using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour
{
    Animator animator;
    float xDir = 0.0f;
    float zDir = 0.0f;
    public float acceleration = 2.0f;
    public float deceleration = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool forward = Input.GetKey("w");
        bool back = Input.GetKey("s");
        bool left = Input.GetKey("a");
        bool right = Input.GetKey("d");

        if(forward && zDir < 2f){
            zDir += Time.deltaTime * acceleration;
        } 
        if(!forward && zDir > 0.0f){
            zDir -= Time.deltaTime * deceleration;
        }
        if(back && zDir > -2f){
            zDir -= Time.deltaTime * acceleration;
        } 
        if(!back && zDir < 0.0f){
            zDir += Time.deltaTime * deceleration;
        }
        if(left && xDir > -2f){
            xDir -= Time.deltaTime * acceleration;
        } 
        if(!left && xDir < 0.0f){
            xDir += Time.deltaTime * deceleration;
        }
        if(right && xDir < 2f){
            xDir += Time.deltaTime * acceleration;
        } 
        if(!right && xDir > 0.0f){
            xDir -= Time.deltaTime * deceleration;
        }

        if(Input.GetButton("Fire1")){
            animator.SetBool("isAttack", true);
        } else{
            animator.SetBool("isAttack", false);
        }
        if(Input.GetButton("Fire2")){
            animator.SetBool("isBlock", true);
        } else {
            animator.SetBool("isBlock", false);
        }

        animator.SetFloat("ZDir", zDir);
        animator.SetFloat("XDir", xDir);
    }
}
