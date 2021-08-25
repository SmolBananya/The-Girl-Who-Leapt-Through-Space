using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PauseGame : MonoBehaviour
{
    public bool gamePaused = false;
    public AudioSource levelMusic;
    public GameObject pauseMenu;
    public AudioSource pauseMusic;
    public AudioSource buttonPress;


    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (gamePaused == false)
            {
                Time.timeScale = 0;
                gamePaused = true;
                Cursor.visible = true;
                levelMusic.Pause();
                pauseMenu.SetActive(true);
                pauseMusic.Play();

            }
            else
            {
                pauseMenu.SetActive(false);
                pauseMusic.Pause();
                levelMusic.UnPause();
                Cursor.visible = false;
                gamePaused = false;
                Time.timeScale = 1;
            }
        }
    }

    public void ResumeGame()
    {
        buttonPress.Play();
        pauseMenu.SetActive(false);
        pauseMusic.Pause();
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
    }

    public void RestartLevel()
    {
        buttonPress.Play();
        pauseMenu.SetActive(false);
        pauseMusic.Pause();
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(2);
    }
    public void QuitToMenu()
    {
        buttonPress.Play();
        pauseMenu.SetActive(false);
        pauseMusic.Pause();
        levelMusic.UnPause();
        Cursor.visible = false;
        gamePaused = false;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }
}
