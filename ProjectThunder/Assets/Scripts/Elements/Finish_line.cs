using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_line : MonoBehaviour
{
    [Header("Postprocessinngg")]  
    public LevelLoader LevelLoader;
    public GameObject YouWinUI;
    public GameObject levelcanvas;
    public GameCanvasManager gamecanvasmanager;
    public GameObject[] LoseColliders;

    [Header("Fireworks particles")]
    public GameObject fireworks;

    [Header("Modes")]
    public bool Testmode = false;
    public bool LoseCollidersinscene;

    [Header("Public scripts")]
    public Timer playertimer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            loadyouwinscreen();
        }
    }

    private void Start()
    {
        if (LoseCollidersinscene)
        {
            foreach (GameObject losecolliders in LoseColliders)
            {
                losecolliders.SetActive(true);
            }
        }

        gamecanvasmanager = FindObjectOfType<GameCanvasManager>();
        YouWinUI.SetActive(false);

    }

    public void loadyouwinscreen()
    {
        playertimer.Finish();
        playertimer.youwinscreentimerpdate();
        levelcanvas.SetActive(false);
        Time.timeScale = 0.2f;
        YouWinUI.SetActive(true);
        if (Testmode == false)
        {
            FindObjectOfType<CoinManager>().Doyouwinscreeenstuf();
        }
        DisableAllLoseColliders();
        Instantiate(fireworks, transform.position, transform.rotation);
    }    

    public void DisableAllLoseColliders()
    {
        foreach (GameObject losecolliders in LoseColliders)
        {
            losecolliders.SetActive(false);
        }
    }
}
