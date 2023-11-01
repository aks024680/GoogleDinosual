using UnityEngine;

namespace DinosaurGoogle
{
    /// <summary>
    /// 玩家動畫控制器
    /// </summary>
    public class EagleAnimation : MonoBehaviour
    {
        Animator animator;
        private void Start()
        {
            animator = GetComponent<Animator>();
            animator.SetBool("Flying", false);
        }
        void Update()
        {
            PlayerAnim();
        }
        private void PlayerAnim()
        {
            if(Input.GetKeyDown(KeyCode.W))
            {
                animator.SetBool("Flying",true);
            }
            else if (Input.GetKeyUp(KeyCode.W))
            {
                animator.SetBool("Flying", false);
            }
            else if(Input.GetKeyDown(KeyCode.S)) {
                animator.SetTrigger("Watering");
            }
        }
    }
}

