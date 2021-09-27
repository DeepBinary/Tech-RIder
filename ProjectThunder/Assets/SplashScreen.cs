using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public float animationduration;
    // Start is called before the first frame update
    void Start()
    {
        LoadMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator LoadMenu()
    {
        yield return new WaitForSeconds(animationduration);
        SceneManager.LoadScene(1);
    }
}
