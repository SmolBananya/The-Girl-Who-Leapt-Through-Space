using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashToMenu : MonoBehaviour
{
    public GameObject SBLogo;
    public GameObject gameTitle;

    void Start()
    {
        StartCoroutine(RunSplash());
    }

    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(0.5f);
        SBLogo.SetActive(true);
        yield return new WaitForSeconds(5f);
        gameTitle.SetActive(true);
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(1);
    }
}
