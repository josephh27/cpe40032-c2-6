using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    
    
    // Start is called before the first frame update
    void Start()
    {
        int spawnInterval = Random.Range(3, 5);
        //To spawn at the start at a random time
        Invoke("SpawnRandomBall", spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        int spawnRange = Random.Range(0, ballPrefabs.Length);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[spawnRange], spawnPos, ballPrefabs[spawnRange].transform.rotation);

        //Using recursion to change the spawning delay thus changing the spawning interval
        int spawnInterval = Random.Range(3, 5);
        Invoke("SpawnRandomBall", spawnInterval);

    }

}
