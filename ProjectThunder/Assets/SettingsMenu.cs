using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    [Header("User interface")]
    public Slider MainVolumeSlider;
    public float volume;
    public AudioMixer MainMixer;

    [Space(20)]
    public Slider musicVolume;
    public float musicvolume;
    public AudioMixer MusicMixer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        musicvolume = musicVolume.value;
    }

    public void SetVolume(float volume)
    {
        MainMixer.SetFloat("Volume", volume);
    }
}
