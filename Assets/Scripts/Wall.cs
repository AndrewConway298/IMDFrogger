using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {

    public Rigidbody2D frogRB;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            Debug.Log("Hit");
            //frogRB.isKinematic = true;
            frogRB.velocity = Vector3.zero;
        }
    }
}
