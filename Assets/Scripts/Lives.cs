using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lives : MonoBehaviour {

    public static int playerLives = 3;

    public Text lives;

    void Start()
    {
        lives.text = playerLives.ToString();
    }
}
