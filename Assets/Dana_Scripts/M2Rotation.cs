using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class M2Rotation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void M2Wheel()
    {
        if (DOTween.IsTweening(transform)) return;
        transform.DORotate(transform.eulerAngles + new Vector3(0, 0, -90), 1);
    }

}
