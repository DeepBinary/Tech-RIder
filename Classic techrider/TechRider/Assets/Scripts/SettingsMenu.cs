using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.PostProcessing;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer audioMixer;
    public Slider volumneslider;
    public PostProcessProfile gamepostprocessinprofile;

    private Vignette vignette;
    private Bloom bloom;
    private ChromaticAberration chromaticalberation;

    [Header("Gradient automation")]
    public TMP_ColorGradient textmeshprocolorgradient;
    public GameObject maintesxtcontainingobject;
    private TextMeshProUGUI[] texttochange;

    void Start()
    {
        texttochange = maintesxtcontainingobject.GetComponentsInChildren<TextMeshProUGUI>();

        foreach (TextMeshProUGUI text in texttochange)
        {
            text.colorGradientPreset = textmeshprocolorgradient;
        }
    }    



    public void Setmusicactive(bool isactive)
    {
        FindObjectOfType<MusicPLayer>().gameObject.SetActive(isactive);

        if(isactive == false)
        {
            volumneslider.interactable = false;
        }

        if (isactive == true)
        {
            volumneslider.interactable = true;
        }
    }

    public void SetMusicVolume (float volume)
    {
        FindObjectOfType<MusicPLayer>().GetComponent<AudioSource>().volume = volume;
    }

    public void SetQuality(int qualityIndex)
    {                    
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    public void SetFullscreen(bool isfullscreen)
    {
        Screen.fullScreen = isfullscreen;
    }

    public void SetMasterVolume(float volume)
    {        
        audioMixer.SetFloat("volume", volume);
    }

    public void MuteAudio(bool ismute)
    {
        //if (ismute)
        //{
        //    audioMixer.SetFloat("volume", 0f);
        //}
        
        //if (!ismute)
        //{
        //    audioMixer.SetFloat("volume", volumneslider.value);
        //}
        
    }

    public void SetPostProcessingToggle(bool isenabled)
    {
        if (isenabled)
        {
            gamepostprocessinprofile.TryGetSettings(out vignette);
            gamepostprocessinprofile.TryGetSettings(out bloom);
            gamepostprocessinprofile.TryGetSettings(out chromaticalberation);
            vignette.intensity.value = 0.44f;
            vignette.smoothness.value = 0.338f;
            bloom.intensity.value = 5f;
        }

        if (!isenabled)
        {
            gamepostprocessinprofile.TryGetSettings(out vignette);
            gamepostprocessinprofile.TryGetSettings(out bloom);
            gamepostprocessinprofile.TryGetSettings(out chromaticalberation);
            vignette.opacity.value = 100f;
            bloom.intensity.value = 0f;
            chromaticalberation.intensity.value = 0f;
        }        
    }
}
