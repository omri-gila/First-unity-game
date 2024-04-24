using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dalivary : MonoBehaviour
{
    int lag=0;
     void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider)
        {
              Debug.Log("boom");
              lag++;
              Debug.Log(lag);
              if(lag == 50)
              {
                Debug.Log("GAME OVER");
                  UnityEditor.EditorApplication.isPlaying = false;
              }
        }
    }



  string TheName;
  [SerializeField] Color32 HesPackColor = new Color32 (1,1,1,1);
  [SerializeField] Color32 NoPackColor = new Color32 (1,1,1,1);

  [SerializeField] float destroy_Dalay = 0.5f;
  //int lag =0;
  bool hescollected;
  SpriteRenderer spriteRenderer;
 void Start() 
 {
  spriteRenderer = GetComponent<SpriteRenderer>();  
  }
   void OnTriggerEnter2D(Collider2D other)
   {
    
     if(other.tag == "Package" && !hescollected)
    {
        Debug.Log("The Package has been collected ");
        hescollected = true;
        spriteRenderer.color = HesPackColor;
        TheName = other.gameObject.name; 
        Debug.Log(TheName);
        Destroy(other.gameObject,destroy_Dalay);
        

    }
    if(other.tag == "Customer" && hescollected && other.name == TheName /*(lag == 1)*/)
    {
      Debug.Log("The shipment has been delivered");
      hescollected = false;
      spriteRenderer.color = NoPackColor ;
      lag = lag*0 ;
      //TheName = null ;
      Destroy(other.gameObject,destroy_Dalay);
      
    }
   }
}
