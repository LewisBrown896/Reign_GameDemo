using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //character contoller already in unity so i do not have to manually code for WASD
    public CharacterController controller;

    //player movement speed
    public float speed = 12f;

    // force applied on the character when falling
    // since number is negative the player will fall along the y axis
    // 9.8 is our force of gravity on earth
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        //for movement along the X and z axis
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");

        //moves character the directioon the camera is facing
        Vector3 move = transform.right * X + transform.forward * Z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

        if(Input.GetKeyDown("space"))
        {
            transform.Translate(Vector3.up * 300 * Time.deltaTime, Space.World);
        }
    }
}
