using Photon.Realtime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour
{
    private GameObject playerboi;

    [Header("is this a launch upwards")]
    public bool jumpPad;
    public int launchHeight;
    [Header("is this a launchPad forward")]
    public bool launchPadForward;
    public int launchforward;      
    [Header("is this a launchPad left")]
    public bool launchPadLeft;
    public int launchleft;  
    [Header("is this a add speedpad")]
    public bool speedupPad;
    public int Speedboost;
    [Header("is this a slowdown pad")]
    public bool ReduceSpeedPad;
    public int slowdown;
    [Header("is this a add jump height")]
    public bool jumpheightpad;
    public int jumpheight;
    [Header("is this a decrease jump height")]
    public bool jumpDecrease;
    public int jumpdecreasamount;

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
            if (ReduceSpeedPad)
            {
                playerboi.GetComponent<Rigidbody>().AddForce(playerboi.transform.forward * -slowdown);
            }
            if (launchPadForward)
            {
                playerboi.GetComponent<Rigidbody>().AddForce(playerboi.transform.forward * launchforward);
            }
            if (launchPadLeft)
            {
                playerboi.GetComponent<Rigidbody>().AddForce(playerboi.transform.right * -launchleft);
            }
            if (speedupPad)
            {
                playerboi.GetComponent<PlayerMovement>().BoostSpeed += Speedboost;
            }
            if (jumpheightpad)
            {
                playerboi.GetComponent<PlayerMovement>().JumpHeight += jumpheight;
            }
            if (jumpDecrease)
            {
                playerboi.GetComponent<PlayerMovement>().JumpHeight -= jumpheight;
            }
        }
    }
}
