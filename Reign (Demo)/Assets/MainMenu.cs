using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //loads the next scene in the queue. in this case it would be the test map, but could launch a game
    public void PlayGame()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); // OG: SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("This Scene is " + SceneManager.GetActiveScene().name); // names the current scene for testing the load game
    }

    //would exit out of the application
    public void QuiteGame()
    {
        Debug.Log("QUIT");//writes to console if QuiteGame runs correctly
        Application.Quit();
    }
    
}
