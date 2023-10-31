
using UnityEngine;

namespace DinosaurGoogle
{

    public class EnemyMoveForward : MonoBehaviour
    {
        
        Rigidbody rb;
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            
            EnemyAddForce();
        }
        void EnemyAddForce()
        {

            rb.AddForce(Vector3.forward * 10000);
        }
    }
}

