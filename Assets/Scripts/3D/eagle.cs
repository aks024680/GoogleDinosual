using System.Collections.Generic;
using UnityEngine;

namespace DinosaurGoogle
{
    /// <summary>
    /// 玩家控制器
    /// </summary>
public class eagle : MonoBehaviour
{
        

    
    
    public float forward = 10;
    Rigidbody rb;
    public float maxValue = 8, minValue = -11;

    float timer;

        private void Start()
        {
            rb = GetComponent<Rigidbody>();
            
        }
        private void Update()
        {
            MoveRange();
            
        }
        
        void MoveRange()
        {
        transform.position += Vector3.forward * -0.1f;
        //transform.position = new Vector3(0,0,0);
        //transform.rotation = new Vector3(xAngle,yAngle,ZAngel,Space.Self);
        //float PosX = Input.GetAxisRaw("Horizontal");
        //float PosY = Input.GetAxisRaw("Vertical");

        float PosX = Input.GetAxisRaw("Horizontal");
        float PosY = Input.GetAxisRaw("Vertical");


        Vector3 point = transform.position;
        point.x = Mathf.Clamp(point.x, -11, 8);
        point.y = Mathf.Clamp(point.y, 3, 12);
        transform.position = point;
        Move();

        //transform.Rotate(xAngle, yAngle, zAngle, Space.Self); //以自身為軸心旋轉
    }
   
    private void Move()
    {
        //向上运动——W
        if (Input.GetKey(KeyCode.W))
        {
            print("w");
            transform.Translate(Vector3.up * Time.deltaTime * 10);
        }

        //向下运动——S
        if (Input.GetKey(KeyCode.S))
        {
            print("s");
            transform.Translate(Vector3.down * Time.deltaTime * 10);
        }

        //向左运动——A
        if (Input.GetKey(KeyCode.A))
        {
            print("a");
            transform.Translate(Vector3.left * Time.deltaTime * 10);
        }

        //向右运动——D
        if (Input.GetKey(KeyCode.D))
        {
            print("d");
            transform.Translate(Vector3.right * Time.deltaTime * 10);
        }

    }

}
}

