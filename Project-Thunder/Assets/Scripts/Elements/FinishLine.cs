using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{ 
    public LevelLoader LevelLoader;
    public GameObject Youwinui, gamecanvas, fireworks;
    public GameCanvasManager gamecanvasmanager;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            loadyouwinscreen();
        }
    }

    private void Start()
    {
        gamecanvasmanager = FindObjectOfType<GameCanvasManager>();
        Youwinui.SetActive(false);
    }

    public void loadyouwinscreen()
    {   
        gamecanvas.SetActive(false);

        Time.timeScale = 0.2f;
        Youwinui.SetActive(true);

        Instantiate(fireworks, transform.position, transform.rotation);
    }
}
