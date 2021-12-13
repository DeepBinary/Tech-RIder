using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public Vector2 Force;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            GameObject player = collision.collider.gameObject;
            if (player.transform.position.y > this.gameObject.transform.position.y)
            {
                player.GetComponent<Rigidbody2D>().AddForce(Force);
            }
        }
    }
}
