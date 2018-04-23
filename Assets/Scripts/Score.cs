using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public static int CurrentScore = 0; //Default current score should always set to 0.

    public Text curScore;

    void Start()
    {
        curScore.text = CurrentScore.ToString();
    }
}
