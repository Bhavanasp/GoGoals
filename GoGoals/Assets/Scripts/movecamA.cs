using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecamA : MonoBehaviour
{

    public Transform player;
    Vector3 offset = new Vector3(0, 0, -5);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(8, 4, player.position.z) + offset;
    }
}
