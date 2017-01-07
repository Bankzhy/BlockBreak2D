using UnityEngine;
using System.Collections;

public class block : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject);
    }

}
