
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour {

    public GameObject gameOverMenu;

    public void RestartGame()
    {
        Score.CurrentScore = 0;
        Lives.playerLives = 3;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameOverMenu.SetActive(false);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
