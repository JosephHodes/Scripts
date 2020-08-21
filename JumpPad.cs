using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private GameObject playerboi;
    public int launchHeight;
    public int launchforward;

    private void Start()
    {
       
    }
    private void OnTriggerEnter(Collider other)        
    {
        playerboi = FindObjectOfType<Rigidbody>().gameObject;
        Debug.Log(other.gameObject.layer);
        if (other.gameObject.layer == playerboi.layer) 
        {
            playerboi.GetComponent<Rigidbody>().AddForce(transform.up * launchHeight);
            playerboi.GetComponent<Rigidbody>().AddForce(transform.forward * launchforward) ;
           
        }
    }
}
