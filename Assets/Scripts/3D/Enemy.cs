using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;
using UnityEngine.PlayerLoop;

namespace DinosaurGoogle
{
    //敵人控制器
    public class Enemy : MonoBehaviour
    {
        public Transform[] spawnPoint;
        public float spawnTime = 1f;
        public GameObject[] enemy;
        float timer;

        private void Awake()
        {
            //InvokeRepeating("Timer", 2f, 1f);
            InvokeRepeating("SpawnObject", spawnTime, 3f);
        }
        private void Update()
        {
            timer += Time.deltaTime;
        }
        public void SpawnObject()
        {

            int spawnEnemy = Random.Range(0, spawnPoint.Length);
            int enemyType = Random.Range(0, enemy.Length);
            Instantiate(enemy[enemyType], spawnPoint[spawnEnemy].position, Quaternion.identity);
        }
        /*private void Timer()
        {
            Debug.Log("此次執行的時間為:" + Time.deltaTime);
            if(Time.deltaTime >= 8)
            {
                CancelInvoke();
            }
        }*/
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                GameManager gameManager = FindObjectOfType<GameManager>();
                if (gameManager != null)
                {
                    gameManager.GameOver();
                    print("123");
                }
            }
        }
    }
}

