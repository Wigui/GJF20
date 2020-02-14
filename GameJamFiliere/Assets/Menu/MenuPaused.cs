using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuPaused : MonoBehaviour

{

     public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject vitesseUI;


    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyUp(KeyCode.Escape))
        {
            

            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }

       
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        vitesseUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        vitesseUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }



}
