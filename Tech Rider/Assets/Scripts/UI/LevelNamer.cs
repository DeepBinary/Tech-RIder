using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelNamer : MonoBehaviour
{
    public void LoadLevel(int index)
    {
        FindObjectOfType<LevelLoader>().LoadScene(index);
    }
}
