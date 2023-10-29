using UnityEngine;

namespace DinosaurGoogle
{
/// <summary>
/// Buff技能控制器
/// </summary>
    public class Buff : MonoBehaviour
    {

        public GameObject objectToSpawn;
        public float spawnInterval = 2.0f;

        void Start()
        {
            // 使用InvokeRepeating方法，每隔一段时间生成一个物体
            InvokeRepeating("SpawnObject", 0.0f, spawnInterval);
        }

        void SpawnObject()
        {
            // 生成物体
            Vector3 spawnPosition = new Vector3(Random.Range(-9, 6), Random.Range(3,12), Random.Range(-30, -280)); // 修改为你想要生成的位置
            GameObject newObj = Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);

            // 检查新生成的物体是否与现有物体重叠
            Collider[] colliders = Physics.OverlapSphere(newObj.transform.position, 1.0f); // 假定半径为1.0

            foreach (Collider collider in colliders)
            {
                if (collider.gameObject != newObj)
                {
                    // 如果有重叠的物体，删除它
                    Destroy(newObj);
                    return;
                }
            }
        }
    }
}

