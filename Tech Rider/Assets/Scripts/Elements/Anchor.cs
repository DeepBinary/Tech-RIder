using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anchor : MonoBehaviour
{
    public GameObject ParticlesPrefab, WinScreen;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) 
        {
            Finish();
        }
    }

    void Finish() 
    {
        Instantiate(ParticlesPrefab, transform.position, transform.rotation);
        WinScreen.SetActive(true);
    }

    private void Start()
    {
        WinScreen.SetActive(false);
    }
}
