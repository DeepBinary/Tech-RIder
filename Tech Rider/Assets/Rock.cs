using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.CompareTag("Player")) 
        {
            //Game over, now you can reage quit all your life
            FindObjectOfType<GameCanvas>().Lose();
            Time.timeScale = 0.5f;
            collider.GetComponent<PlayerMovement>().enabled = false;
        }
    }
}
