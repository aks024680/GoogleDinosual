using DinosaurGoogle;
using UnityEngine;

public class EagleController : MonoBehaviour
{
    [SerializeField, Header("移動速度")]
    private float speed = 3.5f;

    private Rigidbody rig;

    private void Awake()
    {
        rig = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();

    }

    private void Move()
    {
        float h = Input.GetAxis("Horizontal");
        rig.velocity = new Vector3(h * speed, 0, 0);
        float v = Input.GetAxis("Vertical");
        rig.velocity = new Vector3(h * speed, v * speed, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Water"))
        {
            UIController uIController = FindObjectOfType<UIController>();
            if (uIController != null)
            {
                uIController.GetTheWater();
                print("GetWater");
            }
        }
    }
}
