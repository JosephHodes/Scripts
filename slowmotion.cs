using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowmotion : MonoBehaviour
{
    [Range(0,1)]
    public float timeslowamount;
    [Range(0, 100)]
    public int speedup;
    public bool turnonslowmotion;
    public bool turnonslowmotionwithspeed;
    public PlayerMovement player;
    void Start()
    {
        player = GetComponent<PlayerMovement>();
    }
    void Update()
    {
        if (turnonslowmotion)
        {
            Time.timeScale = timeslowamount;
            if (turnonslowmotionwithspeed)
            {

            }
        }
        
    }
}
