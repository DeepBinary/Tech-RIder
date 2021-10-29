using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Transform cameratransform;
    private Vector3 LastCamerapos;
    [SerializeField] float parallaxEffectMultiplier;
    private void Start()
    {
        cameratransform = Camera.main.transform;
        LastCamerapos = cameratransform.position;
    }

    private void LateUpdate()
    {
        Vector3 deltamovement = cameratransform.position- LastCamerapos;
        transform.position += deltamovement * parallaxEffectMultiplier;
        LastCamerapos = cameratransform.position;
    }
}