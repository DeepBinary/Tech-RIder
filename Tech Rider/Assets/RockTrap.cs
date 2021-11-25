using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockTrap : MonoBehaviour
{
    public bool TrapTrigger;
    public float movetime;

    public Transform startpoint;
    public Transform endpoint;
    public GameObject rock;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            TrapTrigger = true;
        }
    }

    private void Update()
    {
        if (TrapTrigger == true)
        {
            Trap();
        }
    }

    public void Trap()
    {
        rock.transform.position =  Vector3.MoveTowards(startpoint.transform.position, endpoint.transform.position, movetime);
        TrapTrigger = false;
    }
}
