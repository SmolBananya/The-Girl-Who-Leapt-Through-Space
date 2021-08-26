using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemPink : MonoBehaviour
{
    public GameObject scoreBox;
    public AudioSource collectSound;

    void OnTriggerEnter()
    {
        GlobalScore.currentScore += 1500;
        collectSound.Play();
        Destroy(gameObject);
    }
}
