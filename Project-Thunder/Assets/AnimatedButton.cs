using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class AnimatedButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public float zoomedscale;
    public float animationtime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerEnter(PointerEventData data)
    {
        transform.LeanScale(new Vector3(zoomedscale, zoomedscale, 0), animationtime);
    } 

    public void OnPointerExit(PointerEventData data)
    {

    }
}
