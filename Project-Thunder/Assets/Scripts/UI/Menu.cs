        using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public float animationspeed;

    private void OnEnable()
    {
        transform.LeanScale(new Vector3(0.95f, 0.95f, 1), 0.001f);

        if (GetComponent<CanvasGroup>() == null)
        {
            gameObject.AddComponent<CanvasGroup>();
        }

        GetComponent<CanvasGroup>().alpha = 0;


        GetComponent<CanvasGroup>().LeanAlpha(1, animationspeed);
        transform.LeanScale(new Vector3(1, 1, 1), animationspeed).setEaseInOutCubic();
    }
}
