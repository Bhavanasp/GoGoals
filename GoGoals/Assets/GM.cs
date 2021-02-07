using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GM : MonoBehaviour
{

    public static float vertVel = 0;
    public static int coinTotal = 0;
    public static float timeTotal = 0;
    public float waittoload = 0;

    public float xScenePos = 8;
    public float yScenePos = 1;
    public float zScenePos = 124;
    public float z;

    public static float zVelAdj = 1;

    public static string lvlCompStatus = "";

    public Transform bbNopit;
    public Transform bbPitMid;
    //public Transform terrain;

    public Transform Coin_n;
    public Transform Coin_z;
    public Transform obst;
    public Transform Capsule; 

    public int randomNo, xRand;

    // Start is called before the first frame update
    void Start()
    {
        //Instantiate(terrain, new Vector3(xScenePos, yScenePos, 40), terrain.rotation);
        //Instantiate(terrain, new Vector3(xScenePos, yScenePos, 82), terrain.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if(zScenePos < 1000) {

            for(float i=0; i<10; i++) {
            
            z = zScenePos;
            randomNo = Random.Range(0, 10);
            xRand = Random.Range(-1, 1);

        //    if(randomNo < 3) {
                Instantiate(obst, new Vector3((xScenePos + 2*xRand), 0.5f, z), obst.rotation);
        

            if(randomNo > 7) {
              //  Instantiate(Coin_n, new Vector3((xScenePos + 2*xRand), 1.5f, z), Coin_n.rotation);
            }

            if((randomNo > 4) && (randomNo < 7)) {
               // Instantiate(Coin_z, new Vector3((xScenePos + 2*xRand), 1.5f, z), Coin_z.rotation);
            }
            z += 4;
        }

           // Instantiate(terrain, new Vector3(xScenePos, yScenePos, 82), terrain.rotation);
            zScenePos += 42;
        }

        timeTotal += Time.deltaTime;

        if(lvlCompStatus == "Fail") {
            waittoload += Time.deltaTime;
        }

        if(waittoload > 1) {
            SceneManager.LoadScene("LevelLost", LoadSceneMode.Single);
        }
    }
}
