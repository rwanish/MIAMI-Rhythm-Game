using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class M1Rotation : MonoBehaviour
{
    float rotation = 90;

    public float coolDown = 5f;
    public float durationCoolDown = 5f;
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    private void Update()
    {
        coolDown -= Time.deltaTime;
    }

    public void M1Wheel()
    {
        if (coolDown > 0f) return;
        if (DOTween.IsTweening(transform)) return;
        transform.DORotate(transform.eulerAngles + new Vector3(0, 0, rotation), 1);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (coolDown > 0f) return;
        if (collision.gameObject.tag == "Player")
        {
            transform.DOKill();
            transform.DORotate(new Vector3(0, 0, 0), 1);

            coolDown = durationCoolDown;
        }
    }
}
