using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using DG.Tweening;

public class Toggleswitch : MonoBehaviour, IPointerDownHandler
{
    [SerializeField]
    private bool Is_On = false;
    public bool IsOn
    {
        get
        {
            return Is_On;
        }
    }

    [SerializeField]
    private RectTransform toggleindicator;
    [SerializeField]
    private Image backgroundimage;

    [SerializeField]  Color Oncolor;
    [SerializeField]  Color Offcolor;

    [SerializeField] private float offx;
    [SerializeField] private float onx;

    [SerializeField] private float tweentime = 0.25f;

    public delegate void ValueChanged(bool value);
    public event ValueChanged valuechanged;

    // Start is called before the first frame update
    void Start()
    {
        Toggle(IsOn);
        offx = toggleindicator.anchoredPosition.x;
        onx = backgroundimage.rectTransform.rect.width - toggleindicator.rect.width + toggleindicator.anchoredPosition.x;

    }

    private void OnEnable()
    {
        
        Toggle(IsOn);
    }

    private void Toggle(bool value)
    {
        if (value != IsOn)
        {
            Is_On = value;

            ToggleColor(IsOn);
            MoveIndicator(IsOn);

            if (valuechanged != null)
            {
                valuechanged(IsOn);
            }
        }
    }

    private void ToggleColor(bool value)
    {
        if (value)
        {
            backgroundimage.DOColor(Oncolor, tweentime);
        } else
        {
            backgroundimage.DOColor(Offcolor, tweentime);
        }
    }

    private void MoveIndicator(bool value)
    {
        if (value)
        {
            toggleindicator.DOAnchorPosX(onx, tweentime);
        } else
        {
            toggleindicator.DOAnchorPosX(offx, tweentime);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Toggle(!IsOn);
    }
}
