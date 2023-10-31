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
        rig.velocity = new Vector3 (h * speed, 0, 0);

    }
}
