using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPLayer : MonoBehaviour
{
    public AudioClip[] musics;
    public AudioSource AudioSource;

    private void Awake()
    {
        int musicplayercount = FindObjectsOfType<MusicPLayer>().Length;   

        if (musicplayercount > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    } 

    // Start is called before the first frame update
    void Start()
    {
        AudioSource = GetComponent<AudioSource>();
        AudioSource.loop = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(!AudioSource.isPlaying)
        {
            AudioSource.clip = GetRandomClip();
            AudioSource.Play();
        }
    }

    private AudioClip GetRandomClip()
    {
        return musics[Random.Range(0, musics.Length)];
    }
}
