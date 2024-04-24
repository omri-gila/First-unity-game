using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carmove : MonoBehaviour
{
  [SerializeField] float Sterspeed = 1f;
  [SerializeField] float Car_speed =20f;
  [SerializeField] float slowSpeed = 20f;
  [SerializeField] float BoostSpeed = 300f;

  private void OnTriggerEnter2D(Collider2D other) 
  {

    if(other.tag == "Speed")
    {
      Car_speed = BoostSpeed ;
    }
    if(other.tag == "Slow"){
      Car_speed = slowSpeed;
    }
    
  }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float SterAmuot = Input.GetAxis("Horizontal") * Sterspeed * Time.deltaTime; 
        float CarAmuot = Input.GetAxis("Vertical") * Car_speed * Time.deltaTime; 

       transform.Rotate(0, 0 , -SterAmuot );
       transform.Translate(0, CarAmuot , 0) ;
    
    }
}
