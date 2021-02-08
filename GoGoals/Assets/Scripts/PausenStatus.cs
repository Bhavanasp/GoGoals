using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PausenStatus : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject gameStatusUI;

    public HealthBar healthBar;
    public ScoreBar scoreBar;
    public CountDown timer;

    public TextMeshProUGUI message;

    int maxScore = 100;

    void Start() {
        pauseMenuUI.SetActive(false);
        gameStatusUI.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(GameIsPaused){
                Resume();
            }
            else{
                Pause();
            }
        }

        if(healthBar.slider.value==0){
            gameStatusUI.SetActive(true);
            message.GetComponent<TextMeshProUGUI>().text = "YOU LOST";
        }

        if(timer.timeLeft==0){
            gameStatusUI.SetActive(true);
            if(scoreBar.slider.value==maxScore){
                message.GetComponent<TextMeshProUGUI>().text = "YOU WON";
            }
            else{
                message.GetComponent<TextMeshProUGUI>().text = "YOU LOST";
            }
        }
    }

    public void Resume(){
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause(){
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Restart(){
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame(){
        Time.timeScale = 1f;
        Application.Quit();
    }
}
