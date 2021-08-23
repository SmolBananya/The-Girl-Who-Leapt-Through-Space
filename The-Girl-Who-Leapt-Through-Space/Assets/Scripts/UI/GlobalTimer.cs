using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalTimer : MonoBehaviour
{
    public GameObject timeDisplay01;
    public bool isTakingTime = false;
    public int seconds = 150;
    public static int extendScore;

	

	void Update () {
		extendScore = seconds;
        
        if (isTakingTime == false)
        {
            StartCoroutine(SubtractSecond());
        }


	}

    IEnumerator SubtractSecond ()
    {
        isTakingTime = true;
        seconds -= 1;
        timeDisplay01.GetComponent<Text>().text = "" + seconds;
        yield return new WaitForSeconds(1);
        isTakingTime = false;
    }
}
