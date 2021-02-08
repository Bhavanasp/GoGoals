using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public GameObject textDisplay;
    public int timeLeft = 15;
    public bool takingAway = false;
    bool trigger = false;

    void Start()
    {
        textDisplay.GetComponent<Text>().text = "00:"+timeLeft;
    }

    void Update()
    {   
        if(Input.GetKey(KeyCode.Space)){
            trigger = true;
        }
    
        if(trigger&&!takingAway&&timeLeft>0)
        {
            StartCoroutine(TimeTake());
        }

    }

    IEnumerator TimeTake()
    {
        
        takingAway = true;
        yield return new WaitForSeconds(1);
        timeLeft -= 1;
        if(timeLeft < 10){
            textDisplay.GetComponent<Text>().text = "00:0"+timeLeft;
        }
        else{
            textDisplay.GetComponent<Text>().text = "00:"+timeLeft;
        }
        takingAway = false;
    }
}
