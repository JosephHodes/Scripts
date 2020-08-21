using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private Rigidbody player;
    private GameObject playerboi;
    public int launchHeight, launchforward;


    private void Start()
    {
        playerboi = FindObjectOfType<PlayerMovement>().gameObject;   
    }
    private void OnCollisionEnter(Collision collision)
    {
        
        if (playerboi)
        {
            playerboi.GetComponent<Rigidbody>().AddForce(transform.up * launchHeight);
            playerboi.GetComponent<Rigidbody>().AddForce(transform.forward * launchforward) ;
           
        }
    }
}
