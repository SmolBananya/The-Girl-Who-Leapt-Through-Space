using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
  public GameObject levelMusic;
    public AudioSource levelComplete;
    public AudioSource UnityWin;

    public GameObject levelTimer;

    void OnTriggerEnter()
    {
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        UnityWin.Play();
        levelComplete.Play();
    }
}
