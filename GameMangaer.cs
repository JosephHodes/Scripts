using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;
using Photon.Pun;
using System;
using UnityEngine.InputSystem;

public class GameMangaer : MonoBehaviourPunCallbacks
{
    public bool isHoldingBall = false;
    public Transform[] SpawnPoint;
    public Transform ballholder;
    private int spawnHolder;
    public int amountofplayers;
    public GameObject ball;
    private void Awake()
    {
        if (PhotonNetwork.IsConnected)
        {
            if(spawnHolder > SpawnPoint.Length)
            {
               spawnHolder =  spawnHolder - spawnHolder;
            }
            else
            {
                spawnHolder++;
            }
            PhotonNetwork.Instantiate("Player", SpawnPoint[UnityEngine.Random.Range(0,1)].position, SpawnPoint[UnityEngine.Random.Range(0, 1)].rotation);
            amountofplayers ++; 
        }

           
    }
    private void Start()
    {
        Instantiate(ball, ballholder.position, ballholder.rotation);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
