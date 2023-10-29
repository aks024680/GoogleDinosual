using UnityEngine;
using UnityEngine.SceneManagement;

namespace DinosaurGoogle
{
    /// <summary>
    /// 遊戲控制器
    /// </summary>
    public class GameManager : MonoBehaviour
    {
        public void GameOver()
        {
            // 游戏结束时的逻辑
            // 这里可以实现游戏结束界面、计分、重启游戏等操作
            // 例如：
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // 重新加载当前场景
            print("GameOver");
        }
    }
}

