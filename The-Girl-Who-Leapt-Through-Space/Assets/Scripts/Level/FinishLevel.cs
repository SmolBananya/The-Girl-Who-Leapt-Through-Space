using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    public GameObject levelMusic;
    public AudioSource levelComplete;
    public AudioSource UnityWin;
    public GameObject levelTimer;
    public GameObject timeLeft;
    public GameObject scoreBG;
    public GameObject score;
    public GameObject totalScore;
    public int timeCalc;
    public int scoreCalc;
    public int totalScored;



    void OnTriggerEnter()
    {
        timeCalc = GlobalTimer.extendScore * 100;
        timeLeft.GetComponent<Text>().text = "Time Left: " + GlobalTimer.extendScore + " x 100";
        score.GetComponent<Text>().text = "Score: " + GlobalScore.currentScore;
        totalScored = GlobalScore.currentScore + timeCalc;
        totalScore.GetComponent<Text>().text = "Total Score: " + totalScored;
        levelMusic.SetActive(false);
        levelTimer.SetActive(false);
        UnityWin.Play();
        levelComplete.Play();
        StartCoroutine(CalculateScore());
    }

    IEnumerator CalculateScore()
    {
        scoreBG.SetActive(true);
        timeLeft.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        score.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        totalScore.SetActive(true);
        yield return new WaitForSeconds(1);
    }
}
