using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveorb : MonoBehaviour
{   

    public KeyCode moveL;
    public KeyCode moveR;
    public KeyCode moveUp;

    public float horizVel = 0;
    public int hori_laneNum = 2, verti_laneNum = 1;
    public string hori_controllocked = "n", up_controllocked = "n", down_controllocked = "n";

    public Transform boomObj;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3 (horizVel,GM.vertVel,4);

        if(Input.GetKeyDown(moveL) && (hori_laneNum>1) && (hori_controllocked == "n")) {
            horizVel = -3.5f;
            StartCoroutine(hori_stopSlide());
            hori_laneNum -= 1;
            hori_controllocked = "y";
        }

        if(Input.GetKeyDown(moveR) && (hori_laneNum<3) && (hori_controllocked == "n")) {
            horizVel = 3.5f;
            StartCoroutine(hori_stopSlide());
            hori_laneNum += 1;
            hori_controllocked = "y";
        }

        if(Input.GetKeyDown(moveUp) && (verti_laneNum<2) && (up_controllocked == "n")) {
            GetComponent<Rigidbody>().AddForce(transform.up * 100f);
            // StartCoroutine(vert_stopSlide()); 
            // verti_laneNum += 1;
            // up_controllocked = "y";   
        }

    }

    void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "lethal") {
            Destroy (gameObject);
            GM.zVelAdj = 0;
            Instantiate(boomObj, transform.position, boomObj.rotation);
            GM.lvlCompStatus = "Fail";
        }

        if(other.gameObject.name == "Capsule(Clone)") {
            Destroy (other.gameObject);
        }
    }

    void OnTriggerEnter(Collider other) {
        if(other.gameObject.name == "rampbottomtrig") {
            GM.vertVel = 2;
        }

        if(other.gameObject.name == "ramptoptrig") {
            GM.vertVel = 0;
        }

        if(other.gameObject.name == "exit") {
            SceneManager.LoadScene("LevelComp", LoadSceneMode.Single);
        }

        if(other.gameObject.name == "coin(Clone)") {
            Destroy(other.gameObject);
            GM.coinTotal += 1;
        }
    }

    IEnumerator hori_stopSlide() {
        yield return new WaitForSeconds(.5f);
        horizVel = 0;
        hori_controllocked = "n";
    }

    IEnumerator vert_stopSlide() {
        yield return new WaitForSeconds(.1f);
        GM.vertVel -= 3;
        verti_laneNum -= 1;
        up_controllocked = "n";
    }
}
