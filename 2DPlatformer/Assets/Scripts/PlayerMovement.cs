using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerbody;

    [SerializeField] float speed = 10f;
    [SerializeField] float jumpForce = 10f;
    public bool isGrounded;
    public Transform groundCheck;
    public LayerMask groundLayer;

    private void Awake()
    {
        playerbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        LeftRightMovement();
    }

    private void Update()
    {
        Jumping();
    }

    private void LeftRightMovement()
    {
        //When a horizontal movement key is pressed this will move the player
        playerbody.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, playerbody.velocity.y);
    }

    private void Jumping()
    {
        //Check if the player is on the ground
        isGrounded = Physics2D.Raycast(groundCheck.position, Vector2.down, 0.1f, groundLayer);

        //Checks if the player is pressing the jump button
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //Applies vertical force to the player for jumping
            playerbody.velocity = new Vector2(playerbody.velocity.x, jumpForce);
        }
    }
}
