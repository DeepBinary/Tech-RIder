using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelsManager : MonoBehaviour
{
    public Level[] levels;
    public int indexoffset;
    public float animationSpeed;

    [Header("UI")]
    public LevelDetailsAnimator leveldetailsanimator;
    public GameObject buttonPrefab;
    public Transform gridgroup;
    public TextMeshProUGUI LevelName;
    public Image Thumbnail;
    public TextMeshProUGUI LevelDifficultyText;
    public Button LevelButton;
    void Start()
    {
        foreach (Level level in levels)
        {
            GameObject button = Instantiate(buttonPrefab, gridgroup);
            button.GetComponentInChildren<Text>().text = (level.index + 1).ToString();
            button.GetComponent<Button>().onClick.AddListener(delegate { UpdateData(level); });
        }
    }

    void Update()
    {
        
    }

    private void LoadLevel(int index)
    {
        FindObjectOfType<LevelLoader>().LoadScene(index);
    }

    void UpdateData(Level level)
    {
        LevelName.text = "Level - " + (level.index + 1).ToString();
        Thumbnail.sprite = level.thumbnail;
        LevelDifficultyText.text = level.Difficulty.ToString();
        LevelButton.onClick.AddListener(delegate { LoadLevel(level.index + indexoffset); });
        leveldetailsanimator.Animate(animationSpeed);
    }
}