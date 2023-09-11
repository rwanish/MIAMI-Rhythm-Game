using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PieceBehavior : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(200, 5).SetLoops(-1, LoopType.Yoyo);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
