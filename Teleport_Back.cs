using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleport_Back : MonoBehaviour
{
    private IEnumerator corutine;
    public float teleportdelaybackposition;
    public SpawnPoint player;
    private Transform beforeloc;
    private InputSystem IS;


    void Start()
    {
        player = FindObjectOfType<SpawnPoint>();
        beforeloc = GameObject.Find("BeforeLoc").transform;
        IS = FindObjectOfType<InputSystem>();
        corutine = teleportbackposition(teleportdelaybackposition);
        beforeloc.position = player.playerClone.transform.position;
        beforeloc.rotation = player.playerClone.transform.rotation;
        StartCoroutine(corutine);
        InvokeRepeating("Teleportback", 0.0001f, 0.0001f);

    }

    private IEnumerator teleportbackposition(float teleportdelaybackposition)
    {
        while (true)
        { 

            beforeloc.position = player.playerClone.transform.position;
            beforeloc.rotation = player.playerClone.transform.rotation;
            yield return new WaitForSeconds(teleportdelaybackposition);
        }
        
    }
    private void Teleportback()
    {
        if (Input.GetKeyDown(KeyCode.RightShift))
        {
            Destroy(player.playerClone);
            var playerClone = Instantiate(player.player, beforeloc.position,beforeloc.rotation);
            player.playerClone = playerClone;

        }
    }
}
