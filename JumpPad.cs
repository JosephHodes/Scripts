using Photon.Realtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private GameObject playerboi;

    public int launchforward;
    public Array meme;

    [Header("is this a jump pad")]
    public bool jumpPad;
    public int launchHeight;
    [Header("is this a slowdown pad")]
    public bool ReduceSpeedPad;
    public int slowdown;

    private void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {

        Debug.Log(collision.gameObject.layer);
        playerboi = collision.gameObject.GetComponent<PlayerMovement>().gameObject;
        if (playerboi) {
            if (jumpPad)
            {
                playerboi.GetComponent<Rigidbody>().AddForce(playerboi.transform.up * launchHeight);
            }

           
        }
    }
}
