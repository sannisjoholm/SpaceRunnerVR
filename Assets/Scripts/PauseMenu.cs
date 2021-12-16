using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject ui;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused == true)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }

    }
    public void Resume()
    {
        ui.SetActive(false);
        Time.timeScale = 1;
        GamePaused = false;
    }
    public void Pause()
    {
        ui.SetActive(true);
        Time.timeScale = 0;
        GamePaused = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void ToTheMenu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

}
