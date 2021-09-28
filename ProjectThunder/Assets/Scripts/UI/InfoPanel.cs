using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanel : MonoBehaviour
{
    public Transform Box;
    public CanvasGroup InfoBackground;
    public bool WindowActive;
    private void OnEnable()
    {
        WindowActive = true;
        InfoBackground.alpha = 0;
        InfoBackground.LeanAlpha(1, 0.5f);

        Box.localPosition = new Vector2(0, -Screen.height - 420);
        Box.LeanMoveLocalY(0, 0.5f).setEaseInExpo().delay = 0.1f;
    }

    public void CloseDialog()
    {
        WindowActive = false;
        InfoBackground.LeanAlpha(0, 0.5f);
        Box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseInExpo().setOnComplete(OnComplete);
    }

    void OnComplete()
    {
        gameObject.SetActive(false);
    }
}
