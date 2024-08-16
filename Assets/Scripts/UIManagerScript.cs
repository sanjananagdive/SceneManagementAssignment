using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//namespace to access methods realted to scene management

public class UIManagerScript : MonoBehaviour
{
    public GameObject welcomePanel;//public variable to access the welcomePanel with the welcome text
    
    //function to change scene from Home to Game
    public void TransitionToGameScene()
    {
        //using fn SceneManager.LoadScene to load the game scene, calling this fn as on click event on the buttons
        SceneManager.LoadScene("GameScene");
    }

    //function to enable the welcome panel
    public void EnableWelcomePanel()
    {
        //using SetActive to enable panel which is initially disabled
        welcomePanel.SetActive(true);
    }

    //function to disable the welcome panel
    public void DisanleWelcomePanel()
    {
        //using SetActive to disable panel which
        welcomePanel.SetActive(false);
    }
}
