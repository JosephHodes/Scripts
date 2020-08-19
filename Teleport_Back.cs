using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Back : MonoBehaviour
{
    private IEnumerator corutine;
    public float teleportdelaybackposition;
    public GameObject player;
    private Transform beforeloc;
    private InputSystem IS;


    void Start()
    {
        
        IS = FindObjectOfType<InputSystem>();
        corutine = teleportbackposition(teleportdelaybackposition);
        beforeloc = player.transform;
        StartCoroutine(corutine);

    }

    private IEnumerator teleportbackposition(float teleportdelaybackposition)
    {
        while (true)
        {
            beforeloc = player.transform;
            yield return new WaitForSeconds(teleportdelaybackposition);
        }
        
    }
    private void FixedUpdate()
    {

        if (Input.GetKeyDown(KeyCode.RightShift)) 
            {
            Destroy(player);
            Instantiate(player, beforeloc);
            }

    }
}
