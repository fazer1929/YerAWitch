using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isGamePaused= false;
    public GameObject pauseMenuUi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(isGamePaused){
                Resume();
            }
            else{
                Pause();
            }
        }   
    }
    public void Resume(){
        isGamePaused = false;
        pauseMenuUi.SetActive(false);
        Time.timeScale = 1f;
    }
    
    public void Pause(){
        isGamePaused = true;
        pauseMenuUi.SetActive(true);
        Time.timeScale = 0f;
    }
    public void GoToMenu(){
        Time.timeScale=1f;
        SceneManager.LoadScene("Menu");
    }
    public void Quit(){
        Application.Quit();
    }
}

