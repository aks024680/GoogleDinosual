using UnityEngine;
using UnityEngine.UI;

namespace DinosaurGoogle
{
    /// <summary>
    /// UI控制器
    /// </summary>
    public class UIController : MonoBehaviour
    {
        [SerializeField, Header("口渴度控制")]
        private Image thirstBar;
       
        public Transform Player;

        
        public float thirstVal;
        float timer;
        private void Start()
        {

            thirstVal = 1f;
            timer = 0;
            //thirstBar = transform.GetChild(1).GetComponent<Image>() = transform.GetComponent<Sprite>();
        }
        private void Update()
        {
            
            timer += Time.deltaTime;
            ThirstBarController();
           
        }
        void ThirstBarController()
        {
            if (timer > 5)
            {
                thirstBar.GetComponent<Image>().fillAmount -= 1f / 10000;
                thirstVal -= 1f / 10000;
            }
            if (thirstVal <= 0)
            {
                GameManager gameManager = FindObjectOfType<GameManager>();
                if (gameManager != null)
                {
                    gameManager.GameOver();
                }
            }
        }
       public void GetTheWater()
        {
            thirstVal = 1f;
            timer = 0;
            thirstBar.GetComponent<Image>().fillAmount = 1f;
            print("Bar");
        }
    }
}

