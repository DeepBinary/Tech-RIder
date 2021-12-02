using UnityEngine;

public class GameCanvas : MonoBehaviour
{
    public Animator gameoveranimator;
    public GameObject PauseMenu;
    public GameObject GameOverMenu;
    public bool ispaused;
    // Start is called before the first frame update
    void Start()
    {
        GameOverMenu.SetActive(false);
        PauseMenu.SetActive(false);
        ispaused = false;
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {
            if (ispaused == false) 
            {
                EnterPause();
                return;
            }

            if (ispaused == true) 
            {
                ExitPause();
                return;
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
}
