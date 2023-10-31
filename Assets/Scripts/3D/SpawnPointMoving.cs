using UnityEngine;

namespace DinosaurGoogle
{
    /// <summary>
    /// 敵人生成點移動
    /// </summary>
    public class SpawnPointMoving : MonoBehaviour
    {
        float timer;
        private void Start()
        {
            timer = 0;
        }
        private void Update()
        {
            timer += Time.deltaTime;
            this.transform.position = new Vector3(3.615396f, 2.505476f,-timer*7);
        }
    }
}
