using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShopManager : MonoBehaviour
{
    public GameObject[] Cars;
    public int currentcarindex;

    public CarBlueprint[] carblueprints;
    public Button Buybutton;
    // Start is called before the first frame update
    void Start()
    {
        foreach(CarBlueprint car in carblueprints)
        {
            if (car.Cost == 0)
            {
                car.IsUnlocked = true;
            } 
            else 
            {
                car.IsUnlocked = PlayerPrefs.GetInt(car.name, 0)== 0 ? false: true;
            }
        }

        currentcarindex = PlayerPrefs.GetInt("SelectedCar", 0);
        foreach (GameObject car in Cars)
        {
            car.SetActive(false);
        }

        Cars[currentcarindex].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        UpdateButtonUI();
    }

    public void ChangeNext ()
    {
        Cars[currentcarindex].SetActive(false);

        currentcarindex++;
        if (currentcarindex == Cars.Length)
        {
            currentcarindex = 0;
        }

        Cars[currentcarindex].SetActive(true);
        PlayerPrefs.SetInt("SelectedCar", currentcarindex);
        CarBlueprint c = carblueprints[currentcarindex];

        if (!c.IsUnlocked)
        {
            return;
        }

        PlayerPrefs.SetFloat("SelectedCar", currentcarindex);
    }

    public void ChangePrevious ()
    {
        Cars[currentcarindex].SetActive(false);

        currentcarindex--;
        if (currentcarindex == -1)
        {
            currentcarindex = Cars.Length - 1;
        }

        Cars[currentcarindex].SetActive(true);
        PlayerPrefs.SetInt("SelectedCar", currentcarindex);
        CarBlueprint c = carblueprints[currentcarindex];

        if (!c.IsUnlocked)
        {
            return;
        }

        PlayerPrefs.SetFloat("SelectedCar", currentcarindex);
    }

    public void UpdateButtonUI ()
    {
        CarBlueprint c = carblueprints[currentcarindex];

        if (c.IsUnlocked == true)
        {
            Buybutton.gameObject.SetActive(false);
        }
        else
        {
            Buybutton.GetComponentInChildren<TextMeshProUGUI>().text = "Buy - " + c.Cost.ToString();
            Buybutton.gameObject.SetActive(true);            
            if (c.Cost <= PlayerPrefs.GetInt("Coins"))
            {
                Buybutton.interactable = true;

            } else
            {
                Buybutton.interactable = false;
            }
        }
    }

    public void UnlockCar ()
    {
        CarBlueprint c = carblueprints[currentcarindex];
        PlayerPrefs.SetInt(c.name, 1);
        PlayerPrefs.SetInt("SelectedCar", currentcarindex);
        c.IsUnlocked = true;
        PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - c.Cost);
    }
}
