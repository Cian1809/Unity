//B00164770
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

	
    private float startDelay = 1.0f;
    private float spawnInterval;

    // Start is called before the first frame update
    void Start()
    {//Removed InvokeRepeating, caused the ball repeating at the same time
        SpawnRandomBall();
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall ()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // instantiate ball at random spawn location
		int ballColour = Random.Range(0, ballPrefabs.Length);//Random range for all ball colours, replacing the [0]
        Instantiate(ballPrefabs[ballColour], spawnPos, ballPrefabs[ballColour].transform.rotation);
		Invoke("SpawnRandomBall", Random.Range(1,5));
		//Range 1 sec to 5 sec for the ball to spawn
		
    }

}
