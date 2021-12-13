using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Image))]
public class TabButton : MonoBehaviour,  IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    public TabGroup tabgroup;
    public Image Background;



    public void OnPointerClick(PointerEventData eventData)
    {
        tabgroup.OntabSelected(this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        tabgroup.OntabEnter(this);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        tabgroup.OntabExit(this);
    }

    // Start is called before the first frame update
    void Start()
    {
        Background = GetComponent<Image>();
        tabgroup.Subscribe(this);
        tabgroup = FindObjectOfType<TabGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
