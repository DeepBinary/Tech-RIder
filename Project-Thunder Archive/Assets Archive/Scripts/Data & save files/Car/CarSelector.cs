using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CarSelector : MonoBehaviour
{
    public CinemachineVirtualCamera cinemachinecamera;
    public GameObject[] Carsig;
    public int currentcarindex;
    // Start is called before the first frame update
    void Start()
    {
        currentcarindex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach (GameObject car in Carsig)
        {
            car.SetActive(false);
        }

        Carsig[currentcarindex].SetActive(true);
        cinemachinecamera.Follow = Carsig[currentcarindex].gameObject.transform;
    }
}
