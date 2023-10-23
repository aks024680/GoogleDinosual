using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle : MonoBehaviour
{
    float movementSpeed = 20;
    public Transform goal;
    Rigidbody rb;
    public float forward = 10;
   
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        rb.velocity += Vector3.forward * -0.1f;
        //transform.position = new Vector3(0,0,0);
        //transform.rotation = new Vector3(xAngle,yAngle,ZAngel,Space.Self);
        //float PosX = Input.GetAxisRaw("Horizontal");
        //float PosY = Input.GetAxisRaw("Vertical");

        float PosX = Input.GetAxisRaw("Horizontal");
        float PosY = Input.GetAxisRaw("Vertical");
        if(transform.position.x < 8 )
        {
            bool v = rb.velocity.x == 8;
        }
        if (transform.positions.x < -11)
        {
            bool v = rb.velocity.x == -11;
        }



        //transform.Rotate(xAngle, yAngle, zAngle, Space.Self); //以自身為軸心旋轉
    }
}
