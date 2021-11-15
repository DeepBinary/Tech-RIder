using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    public InfoPanel LoseMenu;
    public PlayerMovement carcontroller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            LoseMenu.gameObject.SetActive(true);
        }
    }

    private void Start()
    {
        LoseMenu.gameObject.SetActive(false);
        carcontroller = FindObjectOfType<PlayerMovement>();
    }
}
