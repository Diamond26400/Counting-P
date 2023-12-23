using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private bool isGamePaused = false;
    private bool isGameActive = false;

    [SerializeField] GameObject canvas1;
    [SerializeField] GameObject canvas2;
    [SerializeField] GameObject canvas3;

    public string sceneToLoad = "Scene1";


    private void Start()
    {
        GameObject canvas1 = GameObject.Find("Canvas 1");
        GameObject canvas2 = GameObject.Find("Canvas 2");
        GameObject canvas3 = GameObject.Find("Canvas 3");

        //LoadScene();
    }
    void Update()
    {
        // Check for input or events to trigger the different functionalities

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isGamePaused)
            {
                PauseGame();

            }
            else
            {
               
                ResumeGame();
            }
        }
    }
    void LoadScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
    public void ResumeGame()
    {
        Time.timeScale = 1f; // Set time scale to normal (unpause)
        isGamePaused = false;

    }

    public void PauseGame()
    {
        Time.timeScale = 0f; // Set time scale to 0 (pause)
        isGamePaused = true;

    }

    public void QuitGame()
    {
        // This function should be called when the player wants to quit the game
        Application.Quit();
    }

    public void LoadMainMenu()
    {
        // This function should be called when the player wants to go back to the main menu
        Time.timeScale = 1f; // Ensure time scale is set to normal before loading main menu
        SceneManager.LoadScene("MainMenu"); // Replace "MainMenu" with the name of your main menu scene
    }

    public void PlayGame()
    {
        Debug.Log("game");
        // This function should be called when the player wants to start or resume the game
        SceneManager.LoadScene("Scene"); // Replace "GameScene" with the name of your game scene
    }
}
