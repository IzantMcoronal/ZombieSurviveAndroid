using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pausa : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject pauseMenu;

    void Update(){

    }

    public void Resume(){

        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;

    }

    public void Pause(){

        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;

   }
}

