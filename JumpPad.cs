using Photon.Realtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private GameObject playerboi;
    public int launchHeight;
    public int launchforward;
    public Array meme;

    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.layer);
        playerboi = collision.gameObject.GetComponent<PlayerMovement>().gameObject;
        if (playerboi) { 
            playerboi.GetComponent<Rigidbody>().AddForce(playerboi.transform.up * launchHeight);
            playerboi.GetComponent<Rigidbody>().AddForce(playerboi.transform.forward * launchforward);

           
        }
    }
}
