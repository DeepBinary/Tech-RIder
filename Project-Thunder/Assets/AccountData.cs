using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountData : MonoBehaviour
{
    [Header("Debug values")]
    public string PlayerName;
    public int ru;
    public int rankedpoints;
    public bool IsSigned;

    public GameObject signInMenu;

    void Start()
    {
        IsSigned = false;
        signInMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (IsSigned == false)
        {
            signInMenu.SetActive(true);
        }
    }

    public void LoadGameData()
    {
          
    }

    public void SaveGameData()
    {

    }
}
