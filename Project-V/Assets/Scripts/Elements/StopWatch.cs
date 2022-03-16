using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class StopWatch : MonoBehaviour
{
    bool timerActive = false;
    public float currenttime;
    public TextMeshProUGUI timertext;
    // Start is called before the first frame update
    void Start()
    {
        startTimer();
        currenttime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive == true) {
            currenttime = currenttime + Time.deltaTime;
        }
        TimeSpan time= TimeSpan.FromSeconds(currenttime);
        timertext.text = time.Minutes.ToString() + ":" + time.Seconds.ToString();
    }

    public void startTimer() {
        timerActive = true;
    }

    public void stopTimer() {
        timerActive = false;
    }
}
