using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //character contoller already in unity so i do not have to manually code for WASD
    public CharacterController controller;

    public Animator animator;
    //player movement speed
    public float speed = 12f;

    // force applied on the character when falling
    // since number is negative the player will fall along the y axis
    // 9.8 is our force of gravity on earth
    public float gravity = -9.81f;

    public float jumpHeight = 3f;

    //check if the player is grounded
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

        //when w is pressed check if the player is attack or walking
        //allow attack when both are true
        if(Input.GetKey(KeyCode.W) && isGrounded)
        {
            if (animator.GetBool("attacking") == true)
            {
                return;
            }
            else if (animator.GetBool("attacking") == false)
            {
                animator.SetBool("walking", true);
                animator.SetInteger("Condition", 1); // condition 1 = walking animation
            }
        }

        //if the player is not pressing anything play the idle animation
        if(Input.GetKeyUp(KeyCode.W) && isGrounded)
        {
            animator.SetBool("walking", false);
            animator.SetInteger("Condition", 0); // condition 0 is idle
        }
        if(Input.GetMouseButtonDown(0) && isGrounded) //check if the player is attacking if yes attack
            //mouseButton down 0 = left mouse click
        {
            if (animator.GetBool("walking") == true)
            {
                animator.SetBool("walking", false);
                animator.SetInteger("Condition", 0);
            }
            if (animator.GetBool("walking") == false)
            {
               
                StartCoroutine(AttackRoutine());

            }
        }

        if(Input.GetButtonDown("Jump") && isGrounded) // button down input jump = space bar
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            animator.SetInteger("Condition", 5); //condition 5 = jumping animation
       
        }
        if(Input.GetKey(KeyCode.LeftShift) && isGrounded)
        {
            speed = 15f;
            controller.Move(move * speed * Time.deltaTime); //increase speed when left shift is pressed
            animator.SetInteger("Condition", 3); //condition 3 = running
        }
        if(Input.GetKey(KeyCode.LeftControl) && isGrounded) // crouch when leftcontrol is pressed
        {
            animator.SetInteger("Condition", 4); // condition 4 = crouching

        }
        if (Input.GetMouseButtonDown(1) && isGrounded) //mouse button down 1 = Right mouse button
        {
            animator.SetInteger("Condition", 6); // condition 6 = blocking animation.
        }
    }

    IEnumerator AttackRoutine()
    {
        animator.SetBool("attacking", true);
        animator.SetInteger("Condition", 2);
        yield return new WaitForSeconds(1);
        animator.SetInteger("Condition", 0);
        animator.SetBool("attacking", false);
    }
}
