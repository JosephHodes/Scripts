using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowmotion : MonoBehaviour
{
    [Range(0,1)]
    public float timeslowamount;

    public int speedup;
    public bool turnonslowmotion;
    public bool turnonslowmotionwithspeed;
    void Start()
    {
        
    }
    void Update()
    {
        if (turnonslowmotion)
        {
            Time.timeScale= timeslowamount;
        }
    }
}
