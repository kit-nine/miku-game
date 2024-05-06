using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : MonoBehaviour
{
      public float sprintSpeed = 8f; //Speed when sprinting
        public float regularSpeed = 5f; // Regular Speed
        private float currentSpeed; // Current Speed

        private Rigidbody2D rb;
    void Start()
    {
       rb = GetComponent<Rigidbody2D>();
       currentSpeed = regularSpeed;
    }   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = sprintSpeed;
        }
        else
        {
            currentSpeed = regularSpeed;
        }
       //Move the player horizontally
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(moveHorizontal *currentSpeed,rb.velocity.y);
        rb.velocity = movement;
    }
}
