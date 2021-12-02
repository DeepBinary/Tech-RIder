using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderDataUpdater : MonoBehaviour
{
    public Slider SliderToUpdate;
    public TextMeshProUGUI DisplayText;
    public string additionalstring;
    // Start is called before the first frame update
    void Start()
    {
        
        DisplayText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        DisplayText.text = SliderToUpdate.value.ToString() + " " + additionalstring;
    }
}
