using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;
    private bool isJumping = false;

    private Rigidbody2D rb;
    //Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //code for horizontal input
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector2 moveVector = new Vector2(horizontalInput * moveSpeed, rb.velocity.y);

        //player is jumping
        if(Input.GetButtonDown("Jump") && !isJumping){
            moveVector.y = jumpForce;
            isJumping = true;    
        }   
     rb.velocity = moveVector;
    }

    private void OnCollision2D(Collision2D collision){
        if (collision.gameObject.CompareTag("Ground")){
            isJumping = false;
        }
    }


}
