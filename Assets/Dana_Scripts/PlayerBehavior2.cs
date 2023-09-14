using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class PlayerBehavior2 : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody2D rb2D;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 newPos = rb2D.position;
        if (Input.GetAxis("Horizontal") < 0f)
        {
            newPos = newPos + Time.fixedDeltaTime * speed * Vector2.left;
        }
        if (Input.GetAxis("Horizontal") > 0f)
        {
            newPos = newPos + Time.fixedDeltaTime * speed * Vector2.right;
        }
        if (Input.GetAxis("Vertical") < 0f)
        {
            newPos = newPos + Time.fixedDeltaTime * speed * Vector2.down;
        }
        if (Input.GetAxis("Vertical") > 0f)
        {
            newPos = newPos + Time.fixedDeltaTime * speed * Vector2.up;
        }
        rb2D.MovePosition(newPos);
    }

    
     private void Update()
     {

     }

}

