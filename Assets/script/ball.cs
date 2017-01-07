using UnityEngine;
using System.Collections;

public class ball : MonoBehaviour {
    public float speed = 100f;
	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.down*speed;


	}
	void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "racket_1")
        {
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);
            Vector2 dir = new Vector2(x,1).normalized;
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
    float hitFactor(Vector2 ballPos,Vector2 racketPos,float racketwidth)
    {
        return (ballPos.x - racketPos.x) / racketwidth;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
