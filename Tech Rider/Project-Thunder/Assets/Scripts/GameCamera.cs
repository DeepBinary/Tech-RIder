using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameCamera : MonoBehaviour
{
    public float CameraScale;
    // Start is called before the first frame update
    void Start()
    {
        GetComponentInChildren<CinemachineVirtualCamera>().Follow = FindObjectOfType<PlayerMovement>().gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponentInChildren<Camera>().orthographicSize = CameraScale;
    }
}
