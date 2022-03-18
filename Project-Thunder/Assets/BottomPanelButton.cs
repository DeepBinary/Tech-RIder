using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BottomPanelButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float animationspeed;
    public void OnPointerEnter(PointerEventData data)
    {
        transform.LeanScale(new Vector2(1f, 1f), 0.001f);
        transform.LeanScale(new Vector2(1.05f, 1.05f), animationspeed).setEaseInOutCubic();
    }
    
    public void OnPointerExit(PointerEventData data)
    {
        transform.LeanScale(new Vector2(1.05f, 1.05f), 0.001f);
        transform.LeanScale(new Vector2(1f, 1f), animationspeed).setEaseInOutCubic();
    }
}
