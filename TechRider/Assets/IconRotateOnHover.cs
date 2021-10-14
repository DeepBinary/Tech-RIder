using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class IconRotateOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public GameObject icon;
    public float degree;
    public float rotatetime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData eventdata)
    {
        float settime = 0.01f;
        icon.GetComponent<RectTransform>().LeanRotateZ(0, settime);
        icon.GetComponent<RectTransform>().LeanRotateZ(degree, rotatetime);
    }

    public void OnPointerExit(PointerEventData eventdata)
    {
        icon.GetComponent<RectTransform>().LeanRotateZ(0, rotatetime);
    }
}
