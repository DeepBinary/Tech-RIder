using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Portal : MonoBehaviour
{
    public TextMeshProUGUI timertext;
    public GameObject fireworks_vfx;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            FindObjectOfType<GameCanvas>().WinGameUI();
            FindObjectOfType<StopWatch>().stopTimer();
            timertext.text = FindObjectOfType<StopWatch>().currenttime.ToString();
            FindObjectOfType<GameManager>().WrapUpLevel();
            Instantiate(fireworks_vfx, transform.position, transform.rotation);
        }
    }
}
