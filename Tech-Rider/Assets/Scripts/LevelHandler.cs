using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LevelHandler : MonoBehaviour
{
    public LevelDetails[] levels;

    [Header("POP-UP UI")]
    public TextMeshProUGUI Title, time, coinsEarned;
    public Image levelpreview;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenLevelDetailsMenu(int index)
    {

    }
}
