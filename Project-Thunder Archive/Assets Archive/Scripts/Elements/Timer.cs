using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timertext;
    private float starttime;
    private bool finish = false;
    public TextMeshProUGUI YouWinScreenTimer;
    private float t;
    private string minutes;
    private string seconds;

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
        YouWinScreenTimer.text = minutes + ":" + seconds;
        youwinscreencoins.text = "+" + manager.Score.ToString();
    }

}
