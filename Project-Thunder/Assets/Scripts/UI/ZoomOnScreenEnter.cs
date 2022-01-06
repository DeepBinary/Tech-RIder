using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomOnScreenEnter : MonoBehaviour
{
    public float startscale;
    public float animationtime;
    // Start is called before the first frame update
    void Start()
    {
           
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnEnable()
    {
        transform.LeanScale(new Vector3(startscale, startscale, 1), 0.001f);
        transform.LeanScale(new Vector3(1, 1, 1), animationtime).setEaseOutExpo();
    }
}
