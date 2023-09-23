using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectFalsePlatforms : MonoBehaviour
{
    public bool hit;
    public float distToPlatform = 1.5f;
    void Update()
    {
       hit = Physics.Raycast(transform.position, transform.forward, distToPlatform, 1 << 8);
        Debug.DrawRay(transform.position, transform.forward * distToPlatform, Color.red);

        if (hit){
            Debug.Log("Be careful dude");
        } else {
            Debug.Log("All clear");
        }
    }
}

// 1<<8
//pos = codey origin
//dir = transform.forward