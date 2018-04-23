using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {

    public GameObject pauseMenu;

    public void ResumeGame()
    {
        Time.timeScale = 1;
        pauseMenu.SetActive(false);
    }

    public void RestartGame()
    {
        Score.CurrentScore = 0;
        Lives.playerLives = 3;
        Level.CurrentLevel = 1;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        pauseMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
