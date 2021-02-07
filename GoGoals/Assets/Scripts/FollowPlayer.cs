using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    Vector3 offset = new Vector3(0, 0, -3);

    void Update()
    {
        transform.position = new Vector3(50 ,1.5f,player.position.z) + offset;
    }
}
