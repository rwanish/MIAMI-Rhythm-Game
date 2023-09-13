using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;                                                                                                                                                                                                                                                                                                           

public class IDotBehavior : MonoBehaviour
{
    public SpriteRenderer maVariable;
    public Color color = Color.cyan;
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMoveY(200,2).SetLoops(-1, LoopType.Yoyo);
        maVariable.DOColor(color, 2).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
} 