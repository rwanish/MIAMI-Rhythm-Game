using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ChronoManager : MonoBehaviour
{
    public float timer = 0f;
    public float maxTime = 2f;
    public float timer2 = 1f;
    public ColorChange letterToChangeColor;
    public M1Behavior M1;
    public M2Behavior M2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime; // or timer += Time.deltaTime
        timer2 = timer2 + Time.deltaTime; // or timer2 += Time.deltaTime

        while (M1.ValueAngle() != 0 && M2.ValueAngle() != 0)
        {
            if (timer > maxTime) // if timer is greater than 2 second
            {
                if (letterToChangeColor != null)
                {
                    letterToChangeColor.SwitchColor();
                }


                M2.RotateM2();

                timer = 0f; // reset timer
            }
            if (timer2 > maxTime) // if timer is greater than 2 second
            {
                if (letterToChangeColor != null)
                {
                    letterToChangeColor.SwitchColor();
                }
                M1.RotateM1();
                timer2 = 0f; // reset timer
            }
        }
    }
}
