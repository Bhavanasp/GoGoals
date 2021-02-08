using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stats : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        if(GMb.coinTotal == 0 && GMb.timeTotal == 0) {
            if(gameObject.name == "coinScore") {
                GetComponent<TextMesh>().text = "Score: " + GM.coinTotal;
            }
            if(gameObject.name == "time") {
                GetComponent<TextMesh>().text = "Time: " + GM.timeTotal;
            }
        }

        else if(GM.coinTotal == 0 && GM.timeTotal == 0) {
            if(gameObject.name == "coinScore") {
                GetComponent<TextMesh>().text = "Score: " + GMb.coinTotal;
            }
            if(gameObject.name == "time") {
                GetComponent<TextMesh>().text = "Time: " + GMb.timeTotal;
            }
        }
    }
}
