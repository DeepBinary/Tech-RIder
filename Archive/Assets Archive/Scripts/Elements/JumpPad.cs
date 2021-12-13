using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public GameObject Player;
    public Vector2 jumppadforce;

    [Header("Physics")]
    public float bounciness;    
    private BoxCollider2D boxcollider;
    private PhysicsMaterial2D physicsmaterial2d;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            Player.GetComponent<Rigidbody2D>().AddForce(jumppadforce);
        }
    }

    private void Start()
    {
        physicsmaterial2d = new PhysicsMaterial2D();
        boxcollider = GetComponent<BoxCollider2D>();
        Player = FindObjectOfType<CarController>().gameObject;
        boxcollider.sharedMaterial = physicsmaterial2d;        
    }

    private void Update ()
    {
        physicsmaterial2d.bounciness = bounciness;
    }
}
