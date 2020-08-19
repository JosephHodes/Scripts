using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Back : MonoBehaviour
{
    private IEnumerator corutine;
    private bool haspastposition;
    public float teleportdelaybackposition;
    
    private Transform beforeloc;
    private InputSystem IS;


    void Start()
    {
        IS = FindObjectOfType<InputSystem>();
        corutine = teleportbackposition(teleportdelaybackposition);
        beforeloc.position = transform.position;
        StartCoroutine(corutine);

    }

    private IEnumerator teleportbackposition(float teleportdelaybackposition)
    {
        beforeloc.position = transform.position;
        haspastposition = true;
        yield return new WaitForSeconds(teleportdelaybackposition);
    }
    private void FixedUpdate()
    {
        if (haspastposition)
        {
            if (Input.GetKeyDown(IS.TeleportBack))
            {
                transform.position = beforeloc.position;
            }
        }
        else
        {
            Debug.Log("wait dont have a past position");
        }

    }
}
