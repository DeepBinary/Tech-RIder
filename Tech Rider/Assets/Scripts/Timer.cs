using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [Header("TimerStats")]
    public TextMeshProUGUI timertext;
    public TextMeshProUGUI WinScreenTimer;
    private float t;
    private float starttime;
    private string minutes;
    private string seconds;
    private bool finish = false;

    [Header("Update timer here also")]
    public TextMeshProUGUI youwinscreencoins;
    public Manager manager;
    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time;
        manager = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (finish)
        {            
            youwinscreentimerpdate();
            return;
        }            
        t = Time.time - starttime;

        minutes = ((int)t / 60).ToString();
        seconds = (t % 60).ToString("f2");
        timertext.text = minutes + ":" + seconds;
    }

    public void Finish()
    {
        finish = true;
    }

    public void youwinscreentimerpdate()
    {
        WinScreenTimer.text = minutes + ":" + seconds;
        WinScreenTimer.text = "+" + manager.Score.ToString();
    }

}
