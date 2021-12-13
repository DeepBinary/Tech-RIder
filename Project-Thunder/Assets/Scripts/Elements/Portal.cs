using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Portal : MonoBehaviour
{
    public GameObject WinScreen;
    public TextMeshProUGUI coinstext;
    public TextMeshProUGUI timertext;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<GameManager>().Save();
            FindObjectOfType<StopWatch>().stopTimer();
            timertext.text = FindObjectOfType<StopWatch>().currenttime.ToString();
            WinScreen.SetActive(true);
            coinstext.text = FindObjectOfType<GameManager>().CoinsEarned.ToString();
        }
    }

    private void Start()
    {
        WinScreen.SetActive(false);
    }
}
