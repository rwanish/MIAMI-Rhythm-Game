using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior3 : MonoBehaviour
{

    public int score = 0;
    public GameObject triangle;
    public AudioClip coinSound;
    public AudioClip tirSound;
    public Rigidbody2D rb2D;
    public ColorChange2 dotChange;

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
            
       }
    }


    public void Fire()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            AudioEngine.instance.PlaySound(tirSound);
            dotChange.SwitchColor();
            Instantiate(triangle, transform.position, Quaternion.identity);
            score++;
        }
    }





    // Update is called once per frame
    private void Update()
    {

    }
}
