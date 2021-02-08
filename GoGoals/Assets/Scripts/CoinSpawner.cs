using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Obstacle;
    Vector3 position;
    public Transform MainCamera;
    GameObject Temp = null;
    Queue<GameObject> Obstacles;
    
    void Start(){
        position = new Vector3(Random.Range(48, 52), Random.Range(0.5f,1.2f), Random.Range(5,10));
        Obstacles = new Queue<GameObject>();
        for(int i = 0;i<7;i++){
            Temp = Instantiate(Obstacle, position, Quaternion.identity);
            Obstacles.Enqueue(Temp);
            position = new Vector3(Random.Range(49.5f, 50.5f), Random.Range(0.5f,1.2f), position.z+25*Random.Range(1,2));
        }
    }
}
