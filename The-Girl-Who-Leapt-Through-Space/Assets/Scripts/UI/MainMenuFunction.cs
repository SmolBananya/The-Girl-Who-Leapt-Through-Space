using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuFunction : MonoBehaviour
{
    public AudioSource buttonPress;

    void Update()
    {
        Cursor.visible = true;
    }
    public void PlayGame()
    {
        buttonPress.Play();
        RedirectToLevel.redirectToLevel = 3;
        SceneManager.LoadScene(2);
    }

    public void QuitGame()
    {
        buttonPress.Play();
        Application.Quit();
    }

    public void PlayCreds()
    {
        buttonPress.Play();
        SceneManager.LoadScene(4);
    }
}
