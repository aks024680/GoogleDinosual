using UnityEngine;
namespace DinosaurGoogle
{
    /// <summary>
    /// 遊戲管理器
    /// </summary>
    public class GameManager3D : MonoBehaviour
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
