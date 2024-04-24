using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triger : MonoBehaviour
{
    public Color newColor, targetColor;
    public SpriteRenderer spriteRenderer;
    

    public void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // Get the SpriteRenderer component attached to this object.
    }
    void OnTriggerEnter2D(Collider2D other) 
{
   /*
           SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (spriteRenderer != null)
        {
            spriteRenderer.color = newColor;
        }*/
         SpriteRenderer otherSpriteRenderer = other.GetComponent<SpriteRenderer>();// Get the SpriteRenderer component of the interacting object.
        if (otherSpriteRenderer != null)// Check if the interacting object has a SpriteRenderer component.
        {
            // Transfer color from the target object to the interacting object
            targetColor = spriteRenderer.color; // Store the color of the target object in the targetColor variable.
            otherSpriteRenderer.color = targetColor; // Set the color of the interacting object to the color of the target object.

            Debug.Log("FFFFF");
        }

        

        


}



}
