using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelDetailsAnimator : MonoBehaviour
{
    public Transform background;

    public void Animate(float animationspeeed)
    {
        background.LeanScale(new Vector3(1.1f, 1.1f, 1.1f), 0.001f);
        background.LeanScale(new Vector3(1, 1, 1), animationspeeed).setEaseInOutCubic();
    }
}
