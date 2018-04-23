using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

    public GameObject collect;

    void OnTriggerEnter2D()
    {
        Debug.Log("Collected!!!!");
        Score.CurrentScore += 100;
        Destroy(collect);
    }

}
