using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraFwollo : MonoBehaviour
{
    [SerializeField] GameObject thingTofollow;
    void LateUpdate()
    {
        transform.position = thingTofollow.transform.position + new Vector3 (0 , 0 , -10);
    }
}
