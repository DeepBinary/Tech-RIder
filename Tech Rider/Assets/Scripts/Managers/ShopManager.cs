using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public int currentcarindex;
    public GameObject[] Cars;

    void Start()
    {
        currentcarindex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach(GameObject car in Cars)
        {
            car.SetActive(false);
        }
        Cars[currentcarindex].SetActive(true);
    }

    void Update()
    {
        
    }

    public void ChangeNext()
    {
        Cars[currentcarindex].SetActive(false);

        currentcarindex++;
        if (currentcarindex == Cars.Length)
        {
            currentcarindex = 0;
        }
        Cars[currentcarindex].SetActive(true);
        PlayerPrefs.SetInt("SelectrdCar", currentcarindex);
    }

    public void ChangePrevious()
    {
        Cars[currentcarindex].SetActive(false);

        currentcarindex--;
        if (currentcarindex == -1)
        {
            currentcarindex = Cars.Length - 1;
        }
        Cars[currentcarindex].SetActive(true);
        PlayerPrefs.SetInt("SelectrdCar", currentcarindex);
    }
} 
