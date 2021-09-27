using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [Header("Menus")]
    public GameObject PlayMenu;
    public PlayMenu playMenuScript;

    [Header("DATA")]
    public bool PlayMenuTrigger;
    // Start is called before the first frame update
    void Start()
    {
        PlayMenuTrigger = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TogglePlayMenu()
    {
        if (PlayMenuTrigger == false)
        {
            PlayMenuTrigger = true;
            playMenuScript.Open();
            Debug.Log(PlayMenuTrigger);
            return;
        }
        if (PlayMenuTrigger == true)
        {
            PlayMenuTrigger = false;
            playMenuScript.Close();
            Debug.Log(PlayMenuTrigger);
            return;
        }
    }
}
