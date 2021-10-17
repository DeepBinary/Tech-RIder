using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public Manager gamemanager;
    
    // Start is called before the first frame update
    void Start()
    {
        gamemanager = FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Coinstuff();
        }
    }

    public void Coinstuff()
    {
        gamemanager.Score += gamemanager.pointspercoincollect;
        Destroy(this.gameObject);
    }
}
