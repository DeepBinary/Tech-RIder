using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    public Level[] levels;
    public int indexoffset;

    [Header("UI")]
    public GameObject buttonPrefab;
    public Transform gridgroup;
    void Start()
    {
        foreach (Level level in levels)
        {
            GameObject button = Instantiate(buttonPrefab, gridgroup);
            button.GetComponentInChildren<TextMeshProUGUI>().text = (level.index + 1).ToString();
            button.GetComponent<Button>().onClick.AddListener(delegate { LoadLevel(level.index + indexoffset); });
        }
    }

    private void LoadLevel(int index)
    {
        FindObjectOfType<StaticSceneManager>().LoadScene(index);
    }
}