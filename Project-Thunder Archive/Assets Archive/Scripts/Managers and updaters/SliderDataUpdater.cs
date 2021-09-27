using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SliderDataUpdater : MonoBehaviour
{
    public Slider SliderToUpdate;
    public TextMeshProUGUI TextToShow;
    public string additionalstring;
    // Start is called before the first frame update
    void Start()
    {
        TextToShow = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        TextToShow.text = SliderToUpdate.value.ToString() + " " + additionalstring;
    }
}
