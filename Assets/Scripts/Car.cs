using UnityEngine;

public class Car : MonoBehaviour {

    public Rigidbody2D carRB;
    float speed = 1f;

    float minSpeed = 4f;
    float maxSpeed = 10f;

    void Start()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate () { //Physics

        Vector2 move = new Vector2(-transform.right.x, -transform.right.y);
        carRB.MovePosition(carRB.position + move * Time.fixedDeltaTime * speed); //Car will move at same speeed no matter what system run on.
       
    }
}
