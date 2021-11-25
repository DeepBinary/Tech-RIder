using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionTrap : MonoBehaviour
{
    public GameObject RockPrefab;
    public GameObject trapSpawnobj;
    void OnTriggerEnter2D(Collider2D collider) 
    {
        if (collider.gameObject.CompareTag("Player")) 
        {
            Instantiate(RockPrefab, trapSpawnobj.transform.position, trapSpawnobj.transform.rotation);
        }
    }
}
