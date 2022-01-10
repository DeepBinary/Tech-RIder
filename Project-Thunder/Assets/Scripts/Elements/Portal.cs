using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Portal : MonoBehaviour
{
    public TextMeshProUGUI timertext;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<GameCanvas>().WinGameUI();
            FindObjectOfType<StopWatch>().stopTimer();
            timertext.text = FindObjectOfType<StopWatch>().currenttime.ToString();
            FindObjectOfType<GameManager>().WrapUpLevel();
        }
    }
}
