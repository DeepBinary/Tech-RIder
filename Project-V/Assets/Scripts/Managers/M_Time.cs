using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class M_Time : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI DateTime_Text;
    DateTime datetime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        datetime = DateTime.Now;
        DateTime_Text.text = datetime.ToString();
    }
}
