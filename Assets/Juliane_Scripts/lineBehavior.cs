using DG.Tweening;
using UnityEngine;

public class lineBehavior : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        transform.DOScaleX(1 , 2).SetLoops(-1, LoopType.Yoyo).SetEase(Ease.InOutSine);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
