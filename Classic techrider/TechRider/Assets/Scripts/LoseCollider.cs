using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour
{
    public GameObject LoseMenu;
    public CarController carcontroller;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            LoseMenu.SetActive(true);
            carcontroller.SlowmotionEnter(0.4f);
        }
    }

    private void Start()
    {
        LoseMenu.SetActive(false);
        carcontroller = FindObjectOfType<CarController>();
    }

}
