using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public enum Rarity { Common, Uncommon, Rare, SuperRare, Legendary }

public class ShopManager : MonoBehaviour
{
    public Skin[] skins;
    public int currentSkinIndex = 0;

    [Header("UI")]
    public SpriteRenderer carsprite;
    public TextMeshProUGUI speedText;
    public TextMeshProUGUI SkinName;
    public TextMeshProUGUI RarityText;   
    
    // Start is called before the first frame update
    void Start()
    {
        SkinName.text = skins[PlayerPrefs.GetInt("SkinIndex")].name;
        carsprite.sprite = skins[PlayerPrefs.GetInt("SkinIndex")].skin;
        speedText.text = skins[PlayerPrefs.GetInt("SkinIndex")].speed.ToString();
        RarityText.text = skins[PlayerPrefs.GetInt("SkinIndex")].rarity.ToString();
        PlayerPrefs.SetInt("SkinIndex", currentSkinIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Next()
    {
        currentSkinIndex++;
        PlayerPrefs.SetInt("SkinIndex", currentSkinIndex);
        SkinName.text = skins[PlayerPrefs.GetInt("SkinIndex")].name;
        carsprite.sprite = skins[PlayerPrefs.GetInt("SkinIndex")].skin;
        speedText.text = skins[PlayerPrefs.GetInt("SkinIndex")].speed.ToString();
        RarityText.text = skins[PlayerPrefs.GetInt("SkinIndex")].rarity.ToString();
    }

    public void Previous()
    {
        currentSkinIndex--;
        PlayerPrefs.SetInt("SkinIndex", currentSkinIndex);
        SkinName.text = skins[PlayerPrefs.GetInt("SkinIndex")].name;
        carsprite.sprite = skins[PlayerPrefs.GetInt("SkinIndex")].skin;
        speedText.text = skins[PlayerPrefs.GetInt("SkinIndex")].speed.ToString();
        RarityText.text = skins[PlayerPrefs.GetInt("SkinIndex")].rarity.ToString();
    }
}

[System.Serializable]
public class Skin
{
    public Sprite skin;
    public string name;
    public bool purchased;
    public Rarity rarity;
    public float speed;
}
