using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Back : MonoBehaviour
{
    private IEnumerator corutine;
    public float teleportdelaybackposition;
    private Transform player;
    private Transform beforeloc;
    private InputSystem IS;
    private Vector3 pastposition;


    void Start()
    {
        player = GetComponent<Transform>();
        IS = FindObjectOfType<InputSystem>();
        corutine = teleportbackposition(teleportdelaybackposition);
        pastposition = player.position;
        StartCoroutine(corutine);

    }

    private IEnumerator teleportbackposition(float teleportdelaybackposition)
    {
        while (true)
        {
            pastposition = player.position;
            yield return new WaitForSeconds(teleportdelaybackposition);
        }
        
    }
    private void FixedUpdate()
    {

            if (Input.GetKeyDown(IS.TeleportBack))
            {
                player.position = pastposition;
            }

    }
}
