using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using Cinemachine;

public class BuffPanel : MonoBehaviour
{
    public PostProcessProfile GameProfile;
    public CinemachineVirtualCamera gamecamera;

    [Header("Andrenaline")]
    public float bloomintensty;
    public float aftercamreasize;
    public Color colorgradingcolor;
    public float amlpitutegain;
    public float frequencygain;
    public GameObject buffbackground;

    [Header("Bird's eye")]
    public float camerasize;
    public Color birdcolorgradient;
    public GameObject birdseyebackground;

    Bloom bloomlayer = null;
    Vignette vignettelayer = null;
    ColorGrading colorgradinlayer;
    // Start is called before the first frame update
    void Start()
    {
        ExitAndrenaline();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            EnterAndrenaline();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            EnterBirdsEye();
        }
    }

    #region andrenaline
    public void EnterAndrenaline()
    {
        gamecamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = amlpitutegain;
        gamecamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = frequencygain;
        GameProfile.TryGetSettings(out bloomlayer);
        GameProfile.TryGetSettings(out vignettelayer);
        GameProfile.TryGetSettings(out colorgradinlayer);

        bloomlayer.enabled.value = true;
        bloomlayer.intensity.value = bloomintensty;
        bloomlayer.color.value = Color.red;

        vignettelayer.color.value = colorgradingcolor;
        colorgradinlayer.colorFilter.value = Color.red;
        gamecamera.m_Lens.OrthographicSize = Mathf.Lerp(gamecamera.m_Lens.OrthographicSize, aftercamreasize, 1f);
        buffbackground.SetActive(true);
    }

    public void ExitAndrenaline()
    {
        gamecamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_AmplitudeGain = 0;
        gamecamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>().m_FrequencyGain = 0;
        GameProfile.TryGetSettings(out bloomlayer);
        GameProfile.TryGetSettings(out vignettelayer);
        GameProfile.TryGetSettings(out colorgradinlayer);

        bloomlayer.intensity.value = 0;
        bloomlayer.color.value = Color.white;
        bloomlayer.enabled.value = false;        

        vignettelayer.color.value = Color.white;
        colorgradinlayer.colorFilter.value = Color.white;
        gamecamera.m_Lens.OrthographicSize = Mathf.Lerp(aftercamreasize, 8, 1f);
        buffbackground.SetActive(false);
    }
    #endregion

    public void EnterBirdsEye()
    {
        ExitAndrenaline();
        GameProfile.TryGetSettings(out bloomlayer);
        GameProfile.TryGetSettings(out vignettelayer);
        GameProfile.TryGetSettings(out colorgradinlayer);

        vignettelayer.color.value = birdcolorgradient;
        colorgradinlayer.colorFilter.value = birdcolorgradient;
        gamecamera.m_Lens.OrthographicSize = Mathf.Lerp(gamecamera.m_Lens.OrthographicSize, camerasize, 10f);
        birdseyebackground.SetActive(true);
    }
}
