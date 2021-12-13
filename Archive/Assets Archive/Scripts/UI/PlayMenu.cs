using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenu : MonoBehaviour
{
    private void Start()
    {
        transform.localScale = Vector2.zero;
    }

    public void Open()
    {
        transform.LeanScale(Vector2.one, 0.2f);
    }

    public void Close()
    {
        transform.LeanScale(Vector2.zero, 0.4f).setEaseInBack();
    }
}
