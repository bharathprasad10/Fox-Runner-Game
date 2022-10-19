using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //public GameObject obstacle;
    public GameObject[] obstaclePatterns;
    private float timeBtwnSpawn;
    public float startTimeBtwnSpawn;
    public float decreaseTime;
    private float minTime = 0.65f; 

    // Update is called once per frame
    void Update()
    {
        int rand = Random.Range(0, obstaclePatterns.Length);
        if(timeBtwnSpawn <= 0f)
        {
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
            timeBtwnSpawn = startTimeBtwnSpawn;
            if(startTimeBtwnSpawn > minTime)
            {
                startTimeBtwnSpawn -= decreaseTime;
            }
        }
        else
        {
            timeBtwnSpawn -= Time.deltaTime ;
        }
    }
}
