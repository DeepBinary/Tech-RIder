using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelNamer : MonoBehaviour
{
    public GameObject[] buttons;
    int numlevels = 3;

    public void Start()
    {
        numlevels = buttons.Length;
        for (int i = 0; i < numlevels; i++)
        {
            TextMeshProUGUI[] textperbutton = buttons[i].GetComponentsInChildren<TextMeshProUGUI>();
            textperbutton[1].text = (i + 1).ToString();

            buttons[i].GetComponent<Button>().onClick.AddListener(delegate () {

                LoadLevel(i);

            });
        }
    }
    public void LoadLevel(int index)
    {
        FindObjectOfType<LevelLoader>().LoadScene(index);
    }
}
