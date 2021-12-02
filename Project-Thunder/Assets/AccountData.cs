using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccountData : MonoBehaviour
{
    public string PlayerName;
    public int ru;
    public int rankedpoints;
    public bool IsSigned;

    public GameObject signInMenu;
    // Start is called before the first frame update
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
}
