using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Animator animator;
    public Rigidbody rb;
    public Transform player;
    float forwardSpeed = 10f;
    float sideSpeed = 5f;
    float jumpSpeed = 7f;
    
    bool move = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void FixedUpdate()
    { 
        if(Input.GetKey(KeyCode.Space)){
            animator.SetBool("run",true);
            move = true;
        }
        if(move) player.transform.Translate(Vector3.forward*forwardSpeed*Time.deltaTime);
        if(move && Input.GetKey(KeyCode.LeftArrow)){
            player.transform.Translate(Vector3.left*sideSpeed*Time.deltaTime);
        }
        if(move && Input.GetKey(KeyCode.RightArrow)){
            player.transform.Translate(Vector3.right*sideSpeed*Time.deltaTime);
        }
        if(move && Input.GetKey(KeyCode.UpArrow)){
            player.transform.Translate(Vector3.up*jumpSpeed*Time.deltaTime);
        }
    }
}
