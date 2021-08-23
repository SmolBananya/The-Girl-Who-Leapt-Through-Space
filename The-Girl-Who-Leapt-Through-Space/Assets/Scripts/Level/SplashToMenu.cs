using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SplashToMenu : MonoBehaviour
{
   public GameObject theLogo;
   public GameObject presents;

	void Start () {
        StartCoroutine(RunSplash());
	}

    IEnumerator RunSplash()
    {
        yield return new WaitForSeconds(0.5f);
        theLogo.SetActive(true);
        presents.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        SceneManager.LoadScene(1);
    }
}
