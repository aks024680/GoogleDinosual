using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movementSpeed;
    public float startPos;
    public float endPos;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2 (transform.position.x - movementSpeed*Time.deltaTime, transform.position.y);
        if (transform.position.x <= endPos)
        {
            if (gameObject.tag == "Cactus")
            {
                Destroy (gameObject);
            }
            else { 
            transform.position = new Vector2(startPos, transform.position.y);
            }
        }
    }
}
