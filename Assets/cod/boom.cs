using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    int lag=0;
     void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider)
        {
              Debug.Log("boom");
              lag++;
              Debug.Log(lag);
              if(lag == 10)
              {
                  UnityEditor.EditorApplication.isPlaying = false;
               }
        }
      
   
                  

        
      
        
    }
   
}
  
        
    
