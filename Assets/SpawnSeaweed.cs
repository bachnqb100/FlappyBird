using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSeaweed : MonoBehaviour
{
    public GameObject seaweed;
    public float startDelay = 2f;
    public float spawnRate = 1f;
    public float spawnPosX = 7f;
    public float spawnPosY = 2f;

    private void Start()
    {
        InvokeRepeating("RandomSpawnSeaweed", startDelay, spawnRate);
    }
        
    void RandomSpawnSeaweed()
    {
        if (Fish.Alived)
        {
            Vector3 spawnPos = new Vector3(spawnPosX, Random.Range(-spawnPosY, spawnPosY), 0f);
            Instantiate(seaweed, spawnPos, seaweed.transform.rotation);
        }
    }
}
