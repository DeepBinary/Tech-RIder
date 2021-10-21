using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayMenu : MonoBehaviour
{
    public float animationtime;
    public Image background;
    public void OnEnable()
    {
        this.gameObject.transform.LeanSetLocalPosY(-Screen.width);
        this.gameObject.transform.LeanMoveLocalY(0, animationtime).setEaseInOutExpo();
    }

    IEnumerator CloseMenu()
    {
        transform.LeanMoveLocalY(-Screen.width, animationtime).setEaseInOutExpo();
        yield return new WaitForSeconds(animationtime);
        HideObject();
    }

    private void Update()
    {
    
    }

    void HideObject()
    {
        this.gameObject.SetActive(false);
    }

    public void Close()
    {
        StartCoroutine(CloseMenu());
    }
}
