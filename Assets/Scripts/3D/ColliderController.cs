using UnityEngine;

namespace DinosaurGoogle
{
    /// <summary>
    /// 碰撞器事件
    /// </summary>
    public class ColliderController : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Player"))
            {
                GameManager gameManager = FindObjectOfType<GameManager>();
                if (gameManager != null)
                {
                    gameManager.GameOver();
                   
                }
            }
        }
    }
}

