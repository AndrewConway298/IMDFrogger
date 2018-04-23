using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level : MonoBehaviour {

    public static int CurrentLevel = 1;

    public Text curLevel;

    void Start()
    {
        curLevel.text = CurrentLevel.ToString();
    }
}
