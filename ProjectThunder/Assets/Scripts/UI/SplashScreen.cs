using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{    
    public float waittime;
    private LevelLoader leveloader;
    // Start is called before the first frame update
    void Start()
    {
        Screen.SetResolution(1280, 720, false);

        if (GetComponent<AudioSource>() == null)
        {
            gameObject.AddComponent<AudioSource>();
        }
        StartCoroutine(LoadMainMenu());
        GetComponent<AudioSource>().playOnAwake = true;
        leveloader = FindObjectOfType<LevelLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMainMenu()
    {
        yield return new WaitForSeconds(waittime);
        leveloader.LoadScene(1);
    }
}
