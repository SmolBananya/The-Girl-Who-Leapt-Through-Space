using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelDeath : MonoBehaviour
{
    public GameObject youFell;
    public GameObject BGM;
    public GameObject FadeOut;

    void OnTriggerEnter()
    {
        StartCoroutine(YouFell());
    }

    IEnumerator YouFell()
    {
        youFell.SetActive(true);
        BGM.SetActive(false);
        yield return new WaitForSeconds(2);
        FadeOut.SetActive(true);
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(2);
    }
}
