using UnityEngine;
using UnityEngine.PlayerLoop;

namespace DinosaurGoogle
{
    //敵人控制器
    public class Enemy : MonoBehaviour
    {
        public Transform[] spawnPoint;
        public float spawnTime = 2f;
        public GameObject[] enemy;

        private void Start()
        {
            InvokeRepeating("SpawnEnemy", spawnTime, spawnTime);
        }

        private void Update()
        {
            SpawnObject();
        }

        void SpawnObject()
        {
            int spawnEnemy = Random.Range(0, spawnPoint.Length);
            int enemyType = Random.Range(0, enemy.Length);
            Instantiate(enemy[enemyType], spawnPoint[spawnEnemy].position, spawnPoint[spawnEnemy].rotation);
        }
    }
}

