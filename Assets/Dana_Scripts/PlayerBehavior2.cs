using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class PlayerBehavior2 : MonoBehaviour
{
    public float speed = 100f;
    public Rigidbody2D rb2D;
    public int score = 0;
    public GameObject bullet;
    public AudioClip coinSound;
    public AudioClip tirSound;

    // Start is called before the first frame update
    void Start()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "CollectableItem")
        {
            AudioEngine.instance.PlaySound(coinSound);
            Destroy(collision.gameObject);
            score++;
        }
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
        if (Input.GetButtonDown("Fire1"))
        {
            AudioEngine.instance.PlaySound(tirSound);
            Instantiate(bullet, transform.localPosition, Quaternion.identity);
        }
    }

}

