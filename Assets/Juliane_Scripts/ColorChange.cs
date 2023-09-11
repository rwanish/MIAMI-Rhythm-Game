using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class ColorChange : MonoBehaviour
{
    public Color color1 = Color.white;
    public Color color2 = Color.cyan;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    // Change the object's sprite current color, by switching between two colors
    public void SwitchColor()
    {
        Debug.Log("Color Change !"); // write the information "Color Change" in the Console

        SpriteRenderer currentRenderer = GetComponent<SpriteRenderer>(); // get the SpriteRender component situated on the same gameObject

        // Switch between two colors, by testing which one is currently in use, and replacing it by the opposite one
        if (currentRenderer.color == color1)
        {
            currentRenderer.color = color2;
        }
        else
        {
            currentRenderer.color = color1;
        }
    }

    // Automatically called by Unity when a user click on the current gameObject (as long as it has a collider attached)
    private void OnMouseDown()
    {
        SwitchColor();
    }
}
