using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int currentcarindex;
    public GameObject[] Cars;
    // Start is called before the first frame update
    void Start()
    {
        currentcarindex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach(GameObject car in Cars)
        {
            car.SetActive(false);
        }

        Cars[currentcarindex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
