using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public static bool GameIsPaused = false;

    //PauseMenuUI is the games pause menu
    public GameObject PauseMenuUI;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            //checks if the game is paused 
            //if game is paused the application will freeze and pause menu should pop up
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    //continues the game
    void Resume()
    {
        PauseMenuUI.SetActive(false);//pause menu inactive
        Time.timeScale = 1f;//runs the application at normal speed
        GameIsPaused = false;
    }

    //completely stops the game
    void Pause()

    {
        PauseMenuUI.SetActive(true);//pause menu active
        Time.timeScale = 0f; //stops the application from running
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Debug.Log("Loading menu...");
        SceneManager.LoadScene("Menu");
    }

    public void QuitGame()
    {
        Debug.Log("quiting game...");
        Application.Quit();
    }
}
