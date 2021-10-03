using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TabGroup : MonoBehaviour
{
    public List<TabButton> Tabbuttons;
    public Sprite tabIdle;
    public Sprite tabHover;
    public Sprite tabActive;
    public TabButton Selectedtab;
    public List<GameObject> ojectsToSwap;
    
    public void Subscribe(TabButton button)
    {
        if(Tabbuttons == null)
        {
            Tabbuttons = new List<TabButton>();
        }

        Tabbuttons.Add(button);
    }

    public void OntabEnter(TabButton button)
    {
        ResetTabs();
        if(Selectedtab == null || button != Selectedtab)
        {
            button.Background.sprite = tabHover;
        }        
    }

    public void OntabExit(TabButton button)
    {
        ResetTabs();        
    }

    public void OntabSelected(TabButton button)
    {
        Selectedtab = button;
        ResetTabs();
        button.Background.sprite = tabActive;
        int index = button.transform.GetSiblingIndex();
        for (int i = 0; i < ojectsToSwap.Count; i++)
        {
            if (i == index)
            {
                ojectsToSwap[i].SetActive(true);
            }
            else
            {
                ojectsToSwap[i].SetActive(false);
            }
        }
        
    }

    public void ResetTabs()
    {
        foreach (TabButton button in Tabbuttons)
        {
            if (Selectedtab != null && button == Selectedtab)
            {
                continue;
            } 
            button.Background.sprite = tabIdle;
        }
    }
}
