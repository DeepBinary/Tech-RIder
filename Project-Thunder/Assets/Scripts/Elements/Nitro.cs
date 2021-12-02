using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nitro : MonoBehaviour
{
    [HideInInspector] public bool IsDeleted;
    public float BoostForce;
    public GameObject particles;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            IsDeleted = true;
            GameObject player = collision.gameObject;
            player.GetComponent<Rigidbody2D>().AddForce(player.transform.right * BoostForce);
            Instantiate(particles, transform.position, transform.rotation);
        }
    }

    private void Awake()
    {
        IsDeleted = false;
    }
}
