using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopUIUpdater : MonoBehaviour
{
    public ShopManager shopManager;
    public Slider speedlsider;
    public Slider weigthslider;
    public float maxweight;
    public float maxspeed;
    // Start is called before the first frame update
    void Start()
    {
        speedlsider.maxValue = maxspeed;
        weigthslider.maxValue = maxweight;
    }

    // Update is called once per frame
    void Update()
    {
        speedlsider.value = shopManager.carblueprints[shopManager.currentcarindex].speed;
        weigthslider.value = shopManager.carblueprints[shopManager.currentcarindex].weight;
    }
}
