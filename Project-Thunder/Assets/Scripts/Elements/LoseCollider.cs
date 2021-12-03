using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    public Animator LoseMenu;
    public PlayerMovement carcontroller;
    public GameObject GameCanvas;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            carcontroller.gameObject.SetActive(false);
            LoseMenu.gameObject.SetActive(true);
            LoseMenu.SetTrigger("GameOver");
        }
    }

    private void Start()
    {
        carcontroller.gameObject.SetActive(true);
        GameCanvas.SetActive(true);
        LoseMenu.gameObject.SetActive(false);
        carcontroller = FindObjectOfType<PlayerMovement>();
    }
}
