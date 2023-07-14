using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager3D : MonoBehaviour
{
    public float startPosTime;
    public float endPosTime;
    public float movementSpeed;
    public GameObject enemy;
    public GameObject enemySpawnPos;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > endPosTime)
        {
            Instantiate(enemy,enemySpawnPos.transform);
            timer = 0;
        }
    }
}
