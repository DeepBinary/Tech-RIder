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
            GameCanvas.SetActive(false);
            LoseMenu.gameObject.SetActive(true);
            LoseMenu.SetTrigger("GameOver");
        }
    }

    private void Start()
    {
        GameCanvas.SetActive(true);
        GameCanvas = FindObjectOfType<GameCanvasManager>().gameObject;
        LoseMenu.gameObject.SetActive(false);
        carcontroller = FindObjectOfType<PlayerMovement>();
    }
}
