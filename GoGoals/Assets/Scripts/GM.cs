using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{

    public static float vertVel = 0;
    public static float horizVel = 0;
    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public float waittoload = 0;

    public float txScenePos = -13;
    public float tyScenePos = 0.5f;
    public float tzScenePos = 40;
    public float obstx = 8;
    public float obstz = 20;

    public static float zVelAdj = 1;

    public static string lvlCompStatus = "";

    public Transform bbNopit;
    public Transform bbPitMid;
    public Transform terrain;

    public Transform coin1, coin2, coin3, coin4, coin5;
    public Transform obst;
    public Transform Capsule; 

    public int randomNo, xRand;

    // Start is called before the first frame update
    void Start()
    {   
          Instantiate(terrain, new Vector3(txScenePos, tyScenePos, 19), transform.rotation);
          //Instantiate(terrain, new Vector3(xScenePos, yScenePos, 40), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if(obstz < 400) {
            randomNo = Random.Range(0, 9);
            xRand = Random.Range(-1, 1);

            if(randomNo == 1) {
                Instantiate(coin1, new Vector3((obstx + (2 * xRand)), 1.5f, obstz), coin1.rotation);
            }

            else if(randomNo == 2) {
                Instantiate(coin2, new Vector3((obstx + (2 * xRand)), 1.5f, obstz), coin2.rotation);
            }

            else if(randomNo == 3) {
                Instantiate(coin3, new Vector3((obstx + (2 * xRand)), 1.5f, obstz), coin3.rotation);
            }

            else if(randomNo == 4) {
                Instantiate(coin4, new Vector3((obstx + (2 * xRand)), 1.5f, obstz), coin4.rotation);
            }

            else if(randomNo == 5) {
                Instantiate(coin5, new Vector3((obstx + (2 * xRand)), 1.5f, obstz), coin5.rotation);
            }

            else if(randomNo > 5) {
                Instantiate(obst, new Vector3((obstx + (2 * xRand)), 0.5f, obstz), obst.rotation);
            }
                    
            obstz += 4;
        }

        if(tzScenePos < 400) {
            Instantiate(terrain, new Vector3(txScenePos, tyScenePos, tzScenePos), terrain.rotation);
            tzScenePos += 21;
        }

        timeTotal += Time.deltaTime;
        
        if(timeTotal >= 15) {
            if(coinTotal >= 0) {
                SceneManager.LoadScene("LevelComp", LoadSceneMode.Single);
            }
            if(coinTotal < 0) {
                SceneManager.LoadScene("LevelLost", LoadSceneMode.Single);
            }       
        }
    }
}
