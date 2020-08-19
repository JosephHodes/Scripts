using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    private Transform spawn;
    public GameObject player;
    public GameObject playerClone;
    // Start is called before the first frame update
    private void Awake()
    {
        spawn = GetComponent<Transform>();
        playerClone = Instantiate(player, transform.position,transform.rotation);
    }
}
