using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonSpawner : MonoBehaviour {

    
    public GameObject balloonPrefab;

    public Vector2 spawnPositionX;
    public float bottomPosition;

    float spawnTime = 1;
    float nextSpawnTime;

	
	// Update is called once per frame
	void Update () {
        if (Time.time > nextSpawnTime)
        {
            
            nextSpawnTime = Time.time + spawnTime;

            Vector3 spawnPositon = new Vector3(Random.Range(spawnPositionX.x, spawnPositionX.y),
                bottomPosition, bottomPosition);

            GameObject newBallooon = (GameObject)Instantiate(balloonPrefab, spawnPositon, Quaternion.identity);
        }

        
	}
}
