using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public float movespeed = 10f;

    private Rigidbody2D rb;
    PlayerMovement target;
    public Transform targetpos;
    Vector2 targetposvector;
    Vector2 movedirection;
    Vector2 thispos;
    public Vector2 offset;
    Vector2 movement;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = FindObjectOfType<PlayerMovement>();
        movedirection = (target.transform.position - transform.position).normalized * movespeed;
        rb.velocity = new Vector2(movedirection.x, movedirection.y);
        Destroy(gameObject, 3f);

        // Lookat
        Vector3 direction = target.transform.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        rb.rotation = angle;
        direction.Normalize();
        movement = direction;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Player"))
        {
            Debug.Log("Hit!");
            Destroy(gameObject);
        }
    }    

    private void Update()
    {
        targetposvector = target.gameObject.GetComponent<PlayerMovement>().transform.position;
        targetpos = target.gameObject.transform;
    }
}
