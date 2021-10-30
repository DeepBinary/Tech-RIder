using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrolledFinish : MonoBehaviour
{
    public GameObject yourtrolledui;
    // Start is called before the first frame update
    void Start()
    {
        yourtrolledui.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Trolled();
        }
    }

    public void Trolled()
    {
        Time.timeScale = 0f;
        yourtrolledui.SetActive(true);
    }
}
