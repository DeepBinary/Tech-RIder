using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    public Transform Box;
    public CanvasGroup InfoBackground;
    public bool WindowActive;
    public float animationspeed;
    private void OnEnable()
    {
        WindowActive = true;
        InfoBackground.alpha = 0;
        InfoBackground.LeanAlpha(1, 0.5f);

        Box.localPosition = new Vector2(0, -Screen.width);
        Box.LeanMoveLocalY(0, animationspeed).setEaseInOutExpo();
    }

    public void CloseDialog()
    {
        WindowActive = false;
        InfoBackground.LeanAlpha(0, 0.5f);

        Box.LeanMoveLocalY(-Screen.width, animationspeed).setEaseInOutExpo().setOnComplete(OnComplete);
    }

    void OnComplete()
    {
        gameObject.SetActive(false);
        InfoBackground.gameObject.SetActive(false);
    }
}
