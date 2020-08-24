using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTableSpawn : MonoBehaviour
{

    private GameObject milk;
    // Start is called before the first frame update
    [SerializeField]
    private List<MilkSpawnpoint> spawning;
    public int randomNum;
    public GameObject fridge;
    private int amountoffridges;
   

    void Start()
    {
        foreach (MilkSpawnpoint milk in FindObjectsOfType<MilkSpawnpoint>())
        {
            if (!spawning.Contains(milk))
            {
                spawning.Add(milk);
            }
        }
        InvokeRepeating("Spawnfridge",0.01f, 0.1f);

    }
    void Spawnfridge()
    {
        var norepeatingrannumbers = 0;
        if (fridge == null)
        {
            {
                if (norepeatingrannumbers == randomNum)
                {
                    randomNum = UnityEngine.Random.Range(0, spawning.Count);
                }
                else
                {
                    Instantiate(fridge, spawning[randomNum].transform);
                    amountoffridges++;
                    norepeatingrannumbers = randomNum;
                }
            }
        }

    }
    // Update is called once per frame
    void Update()
    {
        randomNum = UnityEngine.Random.Range(0, spawning.Count);
    }
    
}
