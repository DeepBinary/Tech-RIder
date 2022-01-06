using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject statuspanel;
    // Start is called before the first frame update
    void Start()
    {
        statuspanel.SetActive(true);
    }

    void OnEnable()
    {
        statuspanel.SetActive(false);
    }

    private void OnDisable()
    {
        statuspanel.SetActive(true);
    }
}
