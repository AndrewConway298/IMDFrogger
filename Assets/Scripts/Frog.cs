
using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

    public Rigidbody2D frogRB;

    public GameObject gameOverMenu;

    public AudioSource hop, squash;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            frogRB.MovePosition(frogRB.position + Vector2.right);
            hop.Play();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            frogRB.MovePosition(frogRB.position + Vector2.left);
            hop.Play();
        }
            
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            frogRB.MovePosition(frogRB.position + Vector2.up);
            hop.Play();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            frogRB.MovePosition(frogRB.position + Vector2.down);
            hop.Play();
        }
    }

    
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Car")
        {
            squash.Play();
            Lives.playerLives--;
            if (Lives.playerLives == 0)
            {
                Time.timeScale = 0;
                gameOverMenu.SetActive(true);
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            if (Score.CurrentScore > HighScore.TopScore)
            {
                HighScore.TopScore = Score.CurrentScore;
            }
        }
        else if(col.tag == "Wall")
        {
            Debug.Log("Wall Hit");
            frogRB.AddForce(Vector2.zero);
        }
    }
}
