using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public enum Diffuculty { Easy, Medium, Expert, Master, GrandMaster, God}

public class LevelsManager : MonoBehaviour
{
    public Level[] Levels;
    public GameObject buttonprefab;
    public int IndexOffset;

    public TMP_ColorGradient godLevelGradient;
    void Start()
    {
        for (int i = 0; i < Levels.Length; i++)
        {
            GameObject button = Instantiate(buttonprefab, GameObject.Find("ClassicContent").transform);

            int levelindexname = i + 1;
            button.gameObject.name = "Level " + levelindexname.ToString();
            button.GetComponentInChildren<Text>().text = levelindexname.ToString();

            Levels[i].index = i + IndexOffset;
            int Levelindex = i + IndexOffset;

            button.GetComponent<Button>().onClick.AddListener (delegate () {    this.LoadLevel(Levelindex);   });         

            if (Levels[i].Diffuculty == Diffuculty.Easy)
            {
                button.GetComponentInChildren<TextMeshProUGUI>().color = Color.white;
            }

            if (Levels[i].Diffuculty == Diffuculty.Medium)
            {
                button.GetComponentInChildren<TextMeshProUGUI>().color = Color.green;
            }

            if (Levels[i].Diffuculty == Diffuculty.Expert)
            {
                button.GetComponentInChildren<TextMeshProUGUI>().color = Color.blue;
            }

            if (Levels[i].Diffuculty == Diffuculty.Master)
            {
                button.GetComponentInChildren<TextMeshProUGUI>().color = Color.red;
            }

            if (Levels[i].Diffuculty == Diffuculty.GrandMaster)
            {
                button.GetComponentInChildren<TextMeshProUGUI>().color = Color.yellow;
            }

            if (Levels[i].Diffuculty == Diffuculty.God)
            {
                button.GetComponentInChildren<TextMeshProUGUI>().colorGradientPreset = godLevelGradient;
            }
        }
    }

    void Update()
    {
        
    }

    public void LoadLevel(int index)
    {
        FindObjectOfType<LevelLoader>().LoadScene(index);
    }
}



[System.Serializable]
public class Level
{
    public int index;
    public Diffuculty Diffuculty;
}