using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenuItem : MonoBehaviour
{
    public float animationtime;
    private void OnEnable()
    {
        transform.rotation = new Quaternion(0, 360, 0, 0);
        transform.LeanRotateY(0, animationtime);
    }

    public void Close()
    {
        transform.LeanRotateY(360, animationtime);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Close();
        }
    }
}
