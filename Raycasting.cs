using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycasting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        int layerMask;
        layerMask = ~LayerMask.GetMask("Ragdoll");
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3f)) {
                        {
               
                Debug.DrawRay(transform.position, transform.transform.TransformDirection(Vector3.forward) * hit.distance, Color.blue);
                Debug.Log(hit.collider);
                if (hit.collider )
                {

                }
            }
        }
        
    }
}
