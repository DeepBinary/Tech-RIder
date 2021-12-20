using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{
    public GameObject Title, subtitle, buttons, statuspanel;
    public CanvasGroup background;
    public float animationtime;
    // Start is called before the first frame update
    void Start()
    {
        statuspanel.SetActive(true);
    }

    void OnEnable()
    {
        statuspanel.SetActive(false);

        background.LeanAlpha(0, 0.001f);
        background.LeanAlpha(1, animationtime);

        Title.LeanScale(new Vector3(0, 0, 0), 0.001f).setEaseInOutCubic();
        Title.LeanScale(new Vector3(1, 1, 1), animationtime).setEaseInOutCubic();

        subtitle.LeanScale(new Vector3(0, 0, 0), 0.001f).setEaseInOutCubic();
        subtitle.LeanScale(new Vector3(1, 1, 1), animationtime).setEaseInOutCubic();

        buttons.LeanScale(new Vector3(0, 0, 0), 0.001f).setEaseInOutCubic();
        buttons.LeanScale(new Vector3(1, 1, 1), animationtime).setEaseInOutCubic();
    }

    private void OnDisable()
    {
        statuspanel.SetActive(true);
        background.LeanAlpha(0, animationtime);

        Title.LeanScale(new Vector3(0, 0, 0), animationtime).setEaseInOutCubic();

        subtitle.LeanScale(new Vector3(0, 0, 0), animationtime).setEaseInOutCubic();

        buttons.LeanScale(new Vector3(0, 0, 0), animationtime).setEaseInOutCubic();
    }
}
