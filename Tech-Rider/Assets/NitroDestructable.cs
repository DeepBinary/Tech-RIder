using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NitroDestructable : MonoBehaviour
{
    [HideInInspector] public bool IsDeleted;
    public float BoostForce;
    public GameObject particles;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameObject player = collision.gameObject;
            IsDeleted = false;
            player.GetComponent<Rigidbody2D>().AddForce(player.transform.right * BoostForce);
            Instantiate(particles, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }

    private void Start()
    {
        
    }
}
