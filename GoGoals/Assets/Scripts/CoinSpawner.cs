using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public GameObject Obstacle;
    Vector3 position = new Vector3(51,2, 0);
    public Transform MainCamera;
    GameObject Temp = null;
    Queue<GameObject> Obstacles;
    
    void Start(){
        Obstacles = new Queue<GameObject>();
        for(int i = 0;i<1;i++){
            Temp = Instantiate(Obstacle, position, Quaternion.identity);
            Temp.transform.Rotate(90,0,0);
            Obstacles.Enqueue(Temp);
            position = new Vector3(Random.Range(48, 52), 2, position.z+100*Random.Range(1,2));
        }
    }

    void Update(){
        // if(MainCamera.position.z>Obstacles.ElementAt(5).transform.position.z){
        //     for(int i = 0;i<5;i++){
        //         Temp = Instantiate(Obstacle, position, Quaternion.identity);
        //         Obstacles.Enqueue(Temp);
        //         if(position.z<400){position = new Vector3(Random.Range(48, 52), 0, position.z+100*Random.Range(1,2));}
        //         Destroy(Obstacles.Dequeue());
        //     }
        // }
    }
}
