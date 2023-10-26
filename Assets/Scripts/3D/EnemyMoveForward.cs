using UnityEditorInternal.Profiling.Memory.Experimental.FileFormat;
using UnityEngine;

namespace DinosaurGoogle
{

    public class EnemyMoveForward : MonoBehaviour
    {
        Enemy enemyController; 
        Rigidbody rb;
        private void Awake()
        {
            rb = GetComponent<Rigidbody>();
            enemyController = GetComponent<Enemy>();
            EnemyAddForce();
        }
        void EnemyAddForce()
        {

            rb.AddForce(Vector3.forward * 10000);
        }
    }
}

