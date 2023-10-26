using UnityEngine;
namespace DinosaurGoogle
{

    public class Destroy : MonoBehaviour
{
        private void Update()
        {
            Destroythis();
        }
        private void Destroythis()
        {

            Destroy(gameObject, 10f);
        }
    }
}
