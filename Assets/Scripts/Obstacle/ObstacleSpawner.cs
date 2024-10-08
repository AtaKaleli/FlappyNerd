using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{


    [SerializeField] private GameObject obstaclePref;

    [SerializeField] private float randomValue;
    [SerializeField] private float spawnTime;
    private float spawnTimeCounter;


    void Start()
    {
        spawnTimeCounter = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (!GameManager.instance.isGameStarted)
            return;


        spawnTimeCounter -= Time.deltaTime;
        if (spawnTimeCounter < 0)
        {
            spawnTimeCounter = spawnTime;
            SpawnObstacle();
            
        }
    }


    private void SpawnObstacle()
    {
        float randomY = Random.Range(-randomValue, randomValue);

        if (randomY < 0)
            randomY += 1;

        GameObject newObstacle = Instantiate(obstaclePref,new Vector3(transform.position.x,transform.position.y + randomY),Quaternion.identity);
        

    }


}
