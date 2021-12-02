using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class SettingsMinimal : MonoBehaviour
{
    [SerializeField] float DebugVolume;
    public Slider VolumeSlider;
    public AudioMixer MainMixer;
    public void UpdateVolume(float volume) 
    {        
        MainMixer.SetFloat("Volume", volume);
        MainMixer.GetFloat("Volume", out DebugVolume);
    }
}
