using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M1Behavior : MonoBehaviour
{
    private int angle = 90;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //function to rotate M1
    public void RotateM1()
    {
        if (angle <= 270)
        {
            
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
           angle = angle + 90;
        }
        else
        {
            angle = 90;
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);
            angle = angle + 90;
        }
    }
}
