using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effects : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(gameObject.name == "Capsule(Clone)") {
            transform.Rotate(1,0,0);
        }
        if(gameObject.tag == "coin") {
            transform.Rotate(0,3,0);
        }
        if(gameObject.tag == "lethal") {
            transform.Rotate(0,1,0);
        }
    }
}
