using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayMenu : MonoBehaviour
{
    public float animationtime;
    public Image background;
    public void OnEnable()
    {
        this.gameObject.GetComponent<CanvasGroup>().alpha = 0;
        this.gameObject.GetComponent<CanvasGroup>().LeanAlpha(1, animationtime);
        transform.localScale = new Vector3(0, 0, 0);
        transform.LeanScale(new Vector3(1, 1, 0), animationtime).setEaseInOutExpo();
    }

    public void CloseMenu()
    {
        this.gameObject.GetComponent<CanvasGroup>().LeanAlpha(0, animationtime);
        transform.LeanScale(new Vector3(0, 0, 0), animationtime).setEaseInOutExpo().setOnComplete(HideObject);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            CloseMenu();
        }
    }

    void HideObject()
    {
        this.gameObject.SetActive(false);
    }
}
