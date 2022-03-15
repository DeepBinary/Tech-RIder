using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ani_TabMenu : MonoBehaviour
{
    public CanvasGroup group;
    public float animationspeed;

    void Awake()
    {
        group = GetComponent<CanvasGroup>();
    }
    void OnEnable()
    {
        group.LeanAlpha(0, 0.001f);
        group.LeanAlpha(1, animationspeed).setEaseInOutExpo();
    }

    void OnDisable()
    {
        group.LeanAlpha(1, 0.001f);
        group.LeanAlpha(0, animationspeed).setEaseInOutExpo();
    }
}
