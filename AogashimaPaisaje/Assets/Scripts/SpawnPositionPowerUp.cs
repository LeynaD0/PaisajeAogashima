using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPositionPowerUp : MonoBehaviour
{
    [SerializeField]
    Transform[] spawnPositions;
    [SerializeField]
    GameObject powerUpPrefab;
    [SerializeField]
    float time, minTime, maxTime;
    [SerializeField]
    bool powerUpActive;
    [SerializeField]
    int choose, minChoose, maxChoose;

    // Start is called before the first frame update
    void Start()
    {
        time = Random.Range(minTime, maxTime);
        choose = Random.Range(minChoose, maxChoose);
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;

        if(time <= 0)
        {
            
            powerUpActive = true;
            if (powerUpActive == true)
            {
                SpawnPowerUp();
            }
        }

        else
        {
            powerUpActive = false;
        }
    }

    void SpawnPowerUp()
    {
        GameObject power = Instantiate(powerUpPrefab, spawnPositions[choose]);
        time = Random.Range(minTime, maxTime);
        choose = Random.Range(minChoose, maxChoose);
        powerUpActive = false;
    }
}
