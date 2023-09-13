using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class M1Rotation : MonoBehaviour
{
    float rotation = 90;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void M1Wheel()
    {
        if (DOTween.IsTweening(transform)) return;
        transform.DORotate(transform.eulerAngles + new Vector3(0, 0, rotation), 1);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            transform.rotation = Quaternion.Euler(Vector3.forward * 0);
            
            
        }
    }
}
