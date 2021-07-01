using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class enemySpawn : MonoBehaviour
{
    public GameObject[] enemies;
    int enemyNo;
    public float maxPos = 2.4f;
    public float delayTimer = 1f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        timer = delayTimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <=0){
            Vector3 enemyPos = new Vector3(Random.Range(-2.4f,2.4f),transform.position.y,transform.position.z);
            enemyNo = Random.Range(0,3);
            Instantiate (enemies[enemyNo], enemyPos, transform.rotation);
            timer = delayTimer;
        }
        
    }
}
