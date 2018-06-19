using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner: MonoBehaviour
{
    
    public GameObject bossBall;                
    public float spawnTime = 3f;            
    public Transform[] spawnPoints;         


    void Start()
    {
        
        InvokeRepeating("Spawn", spawnTime, spawnTime);
    }


    void Spawn()
    {
        int spawnPointIndex = Random.Range(0, spawnPoints.Length);

       
        Instantiate(bossBall, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
    }
}
