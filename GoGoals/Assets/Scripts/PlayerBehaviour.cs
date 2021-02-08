using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{

    Animator animator;
    public Rigidbody rb;
    public Transform player;
    float forwardSpeed = 10f;
    float sideSpeed = 6f;
    float jumpSpeed = 8f;
    
    bool move = false;

    public Transform boomObj;

    // Start is called before the first frame update
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

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "lethal") {
            GM.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);
            GM.coinTotal -= 1;
        }

        if(other.gameObject.tag == "coin") {
            Destroy(other.gameObject);
            GM.coinTotal += 1;
        }
    }
}