using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;
    public float transitiontime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadNextLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void LoadPreviousLevel()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex - 1));
    }


    IEnumerator LoadLevel(int Levelindex)
    {
        transition.SetTrigger("Fade Out");

        yield return new WaitForSeconds(transitiontime);

        SceneManager.LoadScene(Levelindex);
    }

    public void LoadScene (int LevelIndex)
    {
        StartCoroutine(LoadLevel(LevelIndex));
    } 

    public void QuitGame()
    {
        Debug.Log("Application Quit !");
        Application.Quit();
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }
}
