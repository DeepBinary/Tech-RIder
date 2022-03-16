using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SettingsData
{
    // Sound
    public float volume;
    public float musicvolume;

    //Graphics
    public int qualityindex;
    public int resolutionindex;
    public bool isfullscreen;

    // Customization
    public bool DisplayDateAndtime;
    public bool DisplayGradient;

    public SettingsData (SettingsMenu SettingsData)
    {
        resolutionindex = SettingsData.resolutionindex;
        volume = SettingsData.Volume;
        musicvolume = SettingsData.musicvolume;
        qualityindex = SettingsData.QualityIndex;
        isfullscreen = SettingsData.FullscreenData;
        DisplayDateAndtime = SettingsData.DisplayDateAndTimeToggle.isOn;
    }
}
