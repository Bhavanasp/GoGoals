using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Obstacle;
    Vector3 position = new Vector3(51, 0, 2);
    public Transform MainCamera;
    GameObject Temp = null;
    Queue<GameObject> Obstacles;
    
    void Start(){
        Obstacles = new Queue<GameObject>();
        for(int i = 0;i<8;i++){
            Temp = Instantiate(Obstacle, position, Quaternion.identity);
            Obstacles.Enqueue(Temp);
            position = new Vector3(Random.Range(48, 52), 0, position.z+8*Random.Range(1,2));
        }
    }

    void Update(){
        if(MainCamera.position.z>Obstacles.ElementAt(0).transform.position.z&&position.z<470){
            for(int i = 0;i<8;i++){
                Temp = Instantiate(Obstacle, position, Quaternion.identity);
                Obstacles.Enqueue(Temp);
                position = new Vector3(Random.Range(48, 52), 0, position.z+8*Random.Range(1,2));
            }
        }

        if(MainCamera.position.z>Obstacles.ElementAt(7).transform.position.z){
            for(int i = 0;i<8;i++) Destroy(Obstacles.Dequeue());
        }
    }
}
