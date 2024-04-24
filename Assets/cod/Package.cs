using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Package : MonoBehaviour{

    
    private void OnTriggerEnter2D(Collider2D other)
    {
        string otherTag = other.gameObject.tag; // Get the tag of the collided object.

    {

if (otherTag == "player")
        {
            Debug.Log("Collided with player.");
        }
        else if (otherTag == "enemy")
        {
            Debug.Log("Collided with enemy.");
        }
        else
        {
            Debug.Log("Collided with object of tag: " +  other.gameObject.tag);
        }
    }
}
}

