using UnityEngine;
using TMPro;

public class GameCanvas : MonoBehaviour
{
    public TMP_FontAsset Font;
    public TextMeshProUGUI chargetext, rutext;
    public Animator gameoveranimator;
    public GameObject PauseMenu, GameOverMenu, winscreen, homebutton;

    public bool IsLastLevel;
    private bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        winscreen.SetActive(false);
        homebutton.SetActive(false);
        
        TextMeshProUGUI[] texts = FindObjectsOfType<TextMeshProUGUI>();
        
        foreach (TextMeshProUGUI text in texts)
        {
            text.font = Font;
        }
        GameOverMenu.SetActive(false);
        PauseMenu.SetActive(false);
        ispaused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        rutext.text = FindObjectOfType<GameManager>().Earnedru.ToString();
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (ispaused == false)
            {
                EnterPause();
            }            
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (ispaused == true)
            {
                ExitPause();
            }
        }
            
    }

    public void EnterPause() 
    {
        ispaused = true;
        Time.timeScale = 0f;    
        PauseMenu.SetActive(true);
    }

    public void ExitPause() 
    {
        ispaused = false;
        Time.timeScale = 1f;
        PauseMenu.SetActive(false);
    }

    public void Lose() 
    {
        GameOverMenu.SetActive(true);
        gameoveranimator.SetTrigger("GameOver");
    }

    public void WinGameUI()
    {
        winscreen.SetActive(true);
        homebutton.SetActive(true);
    }
}
