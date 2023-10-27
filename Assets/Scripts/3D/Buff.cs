using UnityEngine;

namespace DinosaurGoogle
{
/// <summary>
/// Buff技能控制器
/// </summary>
    public class Buff : MonoBehaviour
    {

        public Transform[] spawnPoint;
        public float spawnTime = 2f;
        public GameObject[] buff;
        float timer;

        private void Awake()
        {
            //InvokeRepeating("Timer", 2f, 1f);
            InvokeRepeating("SpawnBuff", spawnTime, 0.5f);
        }
        private void Update()
        {
            timer += Time.deltaTime;
        }
        public void SpawnBuff()
        {

            int spawnBuff = Random.Range(0, spawnPoint.Length);
            int buffType = Random.Range(0, buff.Length);
            Instantiate(buff[buffType], spawnPoint[spawnBuff].position, Quaternion.identity);
        }
    }
}

