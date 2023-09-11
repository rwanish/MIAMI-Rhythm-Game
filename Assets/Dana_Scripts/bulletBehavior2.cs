using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletBehavior2 : MonoBehaviour
{
    public float speed = 300f;
    public Rigidbody2D rb2D;
    // Start is called before the first frame update
    void Start()
    {
       
    }

// Update is called once per frame
    void FixedUpdate()
    {
        rb2D.MovePosition(rb2D.position + Time.fixedDeltaTime * speed * Vector2.up);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Destructable")
        {
            Destroy(collision.gameObject); // Destroy other object
            Destroy(gameObject); // Destroy the bullet
        }
    }

}
