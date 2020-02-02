using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    public TextMesh timerText;
    public float secondsCount;
    private int minuteCount;
    private int hourCount;
    // Update is called once per frame
    void Update()
    {
        UpdateTimerUI();
    }


    public void UpdateTimerUI()
    {
        // set timer UI
        secondsCount += Time.deltaTime;
        timerText.text = minuteCount + ":" + (int)secondsCount;
        if (minuteCount < 1 && secondsCount < 60 && secondsCount < 10)
        {
            timerText.text = "  0" + (int)secondsCount;
        }
        else if (minuteCount < 1 && secondsCount < 60)
        {
            timerText.text = " "+(int)secondsCount;
            //timerText.text = minuteCount + ":0" + (int)secondsCount;
        }
        else if (minuteCount >= 1 && secondsCount < 10)
        {
            timerText.text = minuteCount + ":0" + (int)secondsCount;
            //timerText.text = minuteCount + ":0" + (int)secondsCount;
        }
        else if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
        //Debug.Log(minuteCount);

    }
}





