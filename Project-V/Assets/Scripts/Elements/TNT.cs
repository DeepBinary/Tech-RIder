using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TNT : MonoBehaviour
{
    public float FieldOfImpact;
    public float force;
    public LayerMask Layermask;
    public GameObject explosionparticle;

    void Explode()
    {
        Collider2D[] objects = Physics2D.OverlapCircleAll(transform.position, FieldOfImpact, Layermask);

        foreach(Collider2D obj in objects)
        {
            Vector2 direction = obj.transform.position - transform.position;

            obj.GetComponent<Rigidbody2D>().AddForce(direction * force);
        }
        GameObject Explosioneffectins = Instantiate(explosionparticle, transform.position, explosionparticle.transform.rotation);
        Destroy(Explosioneffectins, 7);

        Destroy(this.gameObject);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, FieldOfImpact);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Player")
        {
            Explode();
        }
    }
}
