using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Bomb;
    public float positionXlimit;
    // Start is called before the first frame update
    void Start()
    {

        StartSpawnSpike();

    }

    // Update is called once per frame
    void Update()
    {
          
    }
    void SpawnSpike()
    {
        float randomX = Random.Range(-positionXlimit, positionXlimit);
        Vector2 spawnposition = new Vector2(randomX, transform.position.y);
        Instantiate(Bomb, spawnposition, Quaternion.identity);

    }
    void StartSpawnSpike()
    {
        InvokeRepeating("SpawnSpike", 1, 1);
    }
    public void StopSpawnSpike()
    {
        CancelInvoke("SpawnSpike");
    }
}
