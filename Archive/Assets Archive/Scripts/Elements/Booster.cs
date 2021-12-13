using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Booster : MonoBehaviour
{
    private Rigidbody2D rb;
    public float BoostForce;
    private bool OnBoost;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            OnBoost = true;
            rb.AddForce(rb.gameObject.transform.right * BoostForce);
        }
    }

    private void Start()
    {
        OnBoost = false;
        rb = FindObjectOfType<CarController>().gameObject.GetComponent<Rigidbody2D>();
    }
}
