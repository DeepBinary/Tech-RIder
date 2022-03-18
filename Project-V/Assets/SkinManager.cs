using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SkinManager : MonoBehaviour
{
    public Skin[] skins;
    public GameObject ButtonPrefab;
    public GameObject GridGroup;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Skin skin in skins)
        {
            GameObject button = Instantiate(ButtonPrefab, GridGroup.transform);
            TextMeshProUGUI[] Texts = button.GetComponentsInChildren<TextMeshProUGUI>();
            TextMeshProUGUI costText;
            TextMeshProUGUI nameText;

            foreach (TextMeshProUGUI text in Texts)
            {
                if (text.gameObject.CompareTag("ShopButton;CostText"))
                {
                    costText = text;
                }

                if (text.gameObject.CompareTag("ShopButton;NameText"))
                {
                    nameText = text;
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
