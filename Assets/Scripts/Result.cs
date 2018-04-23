using UnityEngine;
using UnityEngine.SceneManagement;

public class Result : MonoBehaviour {

    void OnTriggerEnter2D()
    {
        Debug.Log("You Win!!!");
        Score.CurrentScore += (100 * Level.CurrentLevel);
        Level.CurrentLevel++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
