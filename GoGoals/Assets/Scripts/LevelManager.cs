using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{

    public string scene;

    public void MovetoMain()
    {
        SceneManager.LoadScene("Start");
    }

    public void Next()
    {
        SceneManager.LoadScene(scene);
    }
}
