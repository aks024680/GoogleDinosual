using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dinosaur : MonoBehaviour
{
    Rigidbody2D rb;
    public float jump;
     bool isJumping;
    public GameMenager gm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            rb.velocity = new Vector2(0, jump);
            isJumping=true;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isJumping = false;
        if(collision.gameObject.tag == "Cactus")
        {
            Debug.Log("111");
            gm.GameOver();
        }
    }
}
