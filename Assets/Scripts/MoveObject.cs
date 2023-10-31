using UnityEngine;

public class MoveObject : MonoBehaviour
{
    [SerializeField]
    private float speed = 3.5f;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        transform.Translate(0, 0, -speed * Time.deltaTime);
    }
}
