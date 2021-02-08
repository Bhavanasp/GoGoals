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
        if(gameObject.name == "coinScore") {
            GetComponent<TextMesh>().text = "Coins: " + GM.coinTotal;
        }
        if(gameObject.name == "time") {
            GetComponent<TextMesh>().text = "Time: " + GM.timeTotal;
        }
    }
}
