using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    
    [Header("Postprocessinngg")]  
    public LevelLoader LevelLoader;
    public GameObject YouWinUI;
    public GameObject levelcanvas;
    public GameCanvasManager gamecanvasmanager;

    [Header("Fireworks particles")]
    public GameObject fireworks;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            loadyouwinscreen();
        }
    }

    private void Start()
    {
        gamecanvasmanager = FindObjectOfType<GameCanvasManager>();
        YouWinUI.SetActive(false);
    }

    public void loadyouwinscreen()
    {
        levelcanvas.SetActive(false);
        Time.timeScale = 0.2f;
        YouWinUI.SetActive(true);
        Instantiate(fireworks, transform.position, transform.rotation);
    }
}
