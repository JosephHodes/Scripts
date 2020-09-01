using System.Collections.Generic;
using UnityEngine;

public class DodgeBall : MonoBehaviour
{
    private PlayerMovement player;
    [SerializeField]
    private List<PlayerMovement> players = new List<PlayerMovement>();

    public uint multiplicationFactor;

    private void Update()
    {
    }
    private void Start()
    {
        foreach (PlayerMovement player in FindObjectsOfType<PlayerMovement>()) // loop through all the players in the scene
        {
            if (!players.Contains(player)) // make sure the player isn't already in the list of players
            {
                players.Add(player); // add the player to the list of players 
            }
        }
        player = players[Random.Range(0, players.Count)]; // choose a random player from the list of players


        InvokeRepeating("FollowBall", 3f,3f);
    }
    private void FollowBall()
    {
        GetComponent<Rigidbody>().AddForce((player.transform.position - transform.position) * multiplicationFactor); // add a force to the rigidbody towards the direction of the player with a speed
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (player)
        {
            Destroy()
        }
    }
}
