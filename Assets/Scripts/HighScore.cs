
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour {

    public static int TopScore;

    public Text highScore;

    void Start () {
        highScore.text = TopScore.ToString();
    }

}
