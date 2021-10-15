using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    private Rigidbody2D rb;
    public float BoostForce;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            rb.AddForce(rb.gameObject.transform.right * BoostForce);
        }
    }

    private void Start()
    {
        rb = FindObjectOfType<PlayerMovement>().gameObject.GetComponent<Rigidbody2D>();
    }
}
