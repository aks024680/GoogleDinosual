using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eagle : MonoBehaviour
{
    float movementSpeed = 20;
    public Transform goal;
    public float xAngle;
    public float yAngle;
    public float zAngle;
    public float forward = 100;
    public float currentPos;
    public CharacterController cc;
    // Start is called before the first frame update
    void Start()
    {
        cc = gameObject.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0,0,0);
        //transform.rotation = new Vector3(xAngle,yAngle,ZAngel,Space.Self);
        //float PosX = Input.GetAxisRaw("Horizontal");
        //float PosY = Input.GetAxisRaw("Vertical");

        float PosX = Input.GetAxisRaw("Horizontal");
        float PosY = Input.GetAxisRaw("Vertical");
        transform.Translate(PosX / 10, PosY / 10, 0);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(PosX , PosY , forward* movementSpeed * Time.deltaTime);
        }

        //transform.Rotate(xAngle, yAngle, zAngle, Space.Self); //以自身為軸心旋轉
    }
}
