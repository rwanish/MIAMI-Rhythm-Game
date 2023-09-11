using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChronoManager2 : MonoBehaviour
{
    public float timer = 0f;
    public float maxTime = 1f;
    public ColorChange letterToChangeColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = timer + Time.deltaTime; // or timer += Time.deltaTime

        if (timer > maxTime) // if timer is greater than 1 second
        {
            if (letterToChangeColor != null)
            {
                letterToChangeColor.SwitchColor();
            }
            timer = 0f; // reset timer
        }
    }
}
