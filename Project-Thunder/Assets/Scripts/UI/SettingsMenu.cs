using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Rendering.PostProcessing;

public class SettingsMenu : MonoBehaviour
{
    [Header("Volume")]
    // MainVolume
    public AudioMixer MainMixer;
    public Slider VolumeSlider;
    public float Volume;

    [Space(10)]
    //Music Volume
    public AudioMixer MusicMixer;
    public Slider musicvolumeSlider;
    public float musicvolume;

    [Space(20)]
    //Graphics
    [Header("Graphics")]
    public GameObject gamecamera;
    // Quality
    public TMP_Dropdown Qualitydropdown;
    public int QualityIndex;
    // Post Processing
    public Toggle postprocessingtoggle;
    public PostProcessProfile[] PostProcessingProfiles;
    public bool currentpostprocessingindex;
    // Resolutions
    public TMP_Dropdown ResoutionDropdown;
    public int resolutionindex;
    Resolution[] resolutions;
    public Toggle isfullscreentoggle;
    public bool FullscreenData;
    private void Start()
    {
        resolutions = Screen.resolutions;

        ResoutionDropdown.ClearOptions();

        List<string> options =  new List<string>();

        int currentresolutionindex = 0;
        for (int i = 0; i < resolutions.Length; i++) 
        {
            string optionstring = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(optionstring);
            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height) 
            {
                currentresolutionindex = 1;
            }
        }
        ResoutionDropdown.AddOptions(options);
        ResoutionDropdown.value = currentresolutionindex;
        ResoutionDropdown.RefreshShownValue();
    }

    private void Update()
    {
        // update volume
        Volume = VolumeSlider.value;
        MainMixer.SetFloat("volume", Volume);
        Qualitydropdown.value = QualityIndex;

        // Update music volume
        musicvolume = musicvolumeSlider.value;
        MusicMixer.SetFloat("MusicVolume", Volume);

        // QUalitySettings;
        Qualitydropdown.value = QualityIndex;
        QualityIndex = Qualitydropdown.value;

        //UpdatePostProcessing
        if (postprocessingtoggle.isOn) 
        {
            int debugindex = 0;
            gamecamera.GetComponent<PostProcessVolume>().profile = PostProcessingProfiles[debugindex];
            currentpostprocessingindex = postprocessingtoggle.isOn;

        } else if (!postprocessingtoggle.isOn)
        {
            int debugindex = 1;
            gamecamera.GetComponent<PostProcessVolume>().profile = PostProcessingProfiles[debugindex];
            currentpostprocessingindex = postprocessingtoggle.isOn;
        }

        postprocessingtoggle.isOn = currentpostprocessingindex;

        // Update isfullscreen
        isfullscreentoggle.isOn = FullscreenData;
    }

    public void SaveSettingData()
    {
        SaveSettings.SaveSettingsData(this);
    }

    public void LoadSettingData()
    {
        SettingsData data = SaveSettings.LoadSettingsData();

        Volume = data.volume;
        VolumeSlider.value = Volume;
        QualityIndex = data.qualityindex;
        QualitySettings.SetQualityLevel(QualityIndex);
        musicvolume = data.musicvolume;
        musicvolumeSlider.value = musicvolume;
        currentpostprocessingindex = data.postprocessing;
        resolutionindex = data.resolutionindex;
        ResoutionDropdown.value = resolutionindex;
        FullscreenData = data.isfullscreen;
        isfullscreentoggle.isOn = FullscreenData;
    }

    public void SetQUality(int qualityindex)
    {
        int debugindex = qualityindex;
        QualityIndex = debugindex;
        QualitySettings.SetQualityLevel(debugindex); 
    }

    public void SetisFullscreen(bool isfullscreen) 
    {
        Screen.fullScreen = isfullscreen;
        FullscreenData = isfullscreen;
    }

    public void setResolution(int resolutionindex) 
    {
        Resolution ScreenRes = resolutions[resolutionindex];
        Screen.SetResolution(ScreenRes.width, ScreenRes.height, Screen.fullScreen);
        resolutionindex = ResoutionDropdown.value;
    }
}
