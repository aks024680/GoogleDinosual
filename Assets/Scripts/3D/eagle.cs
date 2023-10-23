using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle : MonoBehaviour
{
    
    public Transform goal;
    
    public float forward = 10;
    Rigidbody rb;
    public float maxValue = 8, minValue = -11;

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
        transform.position += Vector3.forward * -0.1f;
        //transform.position = new Vector3(0,0,0);
        //transform.rotation = new Vector3(xAngle,yAngle,ZAngel,Space.Self);
        //float PosX = Input.GetAxisRaw("Horizontal");
        //float PosY = Input.GetAxisRaw("Vertical");

        float PosX = Input.GetAxisRaw("Horizontal");
        float PosY = Input.GetAxisRaw("Vertical");
        if(transform.position.x > 8 && transform.position.x < -11)
        {
            rb.velocity.x = Mathf.Clamp(PosX, minValue, maxValue);
        }
        



        //transform.Rotate(xAngle, yAngle, zAngle, Space.Self); //以自身為軸心旋轉
    }
}
