using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Finish_line : MonoBehaviour
{
    [Header("Postprocessinngg")]
    public PostProcessVolume Postprocessingvolume;
    private ChromaticAberration chromaticalberation;    
    public LevelLoader LevelLoader;
    public GameObject YouWinUI;
    private Vignette vignete;
    public GameObject levelcanvas;
    public gamecanvasmanager gamecanvasmanager;
    public GameObject[] LoseColliders;
    public TrolledFinish[] trolledfinishes;

    [Header("Fireworks particles")]
    public GameObject fireworks;

    [Header("Modes")]
    public bool Testmode = false;
    public bool LoseCollidersinscene;
    public bool Trolledfinishinscene;

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

        if (Trolledfinishinscene)
        {

            foreach (TrolledFinish trolledfinish in trolledfinishes)
            {
                trolledfinish.enabled = true;
            }
        }

        gamecanvasmanager = FindObjectOfType<gamecanvasmanager>();
        YouWinUI.SetActive(false);

    }

    public void loadyouwinscreen()
    {
        playertimer.Finish();
        playertimer.youwinscreentimerpdate();
        levelcanvas.SetActive(false);
        Time.timeScale = 0.2f;
        Postprocessingvolume.profile.TryGetSettings(out vignete);
        Postprocessingvolume.profile.TryGetSettings(out chromaticalberation);
        vignete.smoothness.value = 0.6f;
        chromaticalberation.intensity.value = 1;
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

    public void DisableTrolledmenu()
    {
        foreach (TrolledFinish trolledfinish in trolledfinishes)
        {
            trolledfinish.enabled = false;
        }
    }
}
