using UnityEngine;
using System.Collections;

public class racket : MonoBehaviour {
    public float speed = 150f;
    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
    }
}
