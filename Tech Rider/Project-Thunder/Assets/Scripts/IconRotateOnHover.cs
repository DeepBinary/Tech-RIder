using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;

public class IconRotateOnHover : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public RectTransform icon;
    public float degree;
    public float rotatetime;

    public void OnPointerEnter(PointerEventData eventdata)
    {
        float settime = 0.01f;
        icon.LeanRotateZ(0, settime);
        icon.LeanRotateZ(degree, rotatetime);
    }

    public void OnPointerExit(PointerEventData eventdata)
    {
        icon.LeanRotateZ(0, rotatetime);        
    }
}
