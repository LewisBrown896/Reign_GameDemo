using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    //public float rotSpeed = 80;//rotation speed

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;//terrian

    // Vector3 moveDir = Vector3.zero;

    public Animator anim;
    Vector3 velocity;
    bool isGrounded;

    //public int maxHealth = 100;
    //public int currentHealth;

   // public HealthBar healthBar;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
       // currentHealth = maxHealth;
       // healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
       
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") )//&& isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
        /**
                if (Input.GetKey (KeyCode.W))
                {
                    moveDir = new Vector3(0, 0, 1);
                    moveDir *= speed;
                    moveDir = transform.TransformFirection(moveDir);
                }
                if (Input.GetKeyUp (KeyCode.W))
                {
                    moveDir = new Vector3(0, 0, 0);
                    moveDir = new Vector3(0, 0, 0);

                }
        **/
       
        Walk ();
        GetInput();
        Block();
        Run();
        crouch();
    }

    void Walk()
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (anim.GetBool("attacking") == true)
            {
                return;
            }
            else if (anim.GetBool("attacking") == false)
            {
                anim.SetBool("walking", true);
                anim.SetInteger("condition", 1);
            }
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("walking", false);
            anim.SetInteger("condition", 0);
        }
    }
    void GetInput()
    {
        if(Input.GetMouseButtonDown (0))
        {
            
            if (anim.GetBool("walking") == true)
            {
                anim.SetBool("walking", false);
                anim.SetInteger("condition", 0);
            }
           if (anim.GetBool ("walking") == false)
            {
                Attack();
            }
        }
    }

    void Attack()
    {
        StartCoroutine (AttackRoutine());
    }

    IEnumerator AttackRoutine()
    {
        anim.SetBool("attacking", true);
        anim.SetInteger("condition", 2);
        yield return new WaitForSeconds(1);
        anim.SetInteger("condition", 0);
        anim.SetBool("attacking", false);
    }

    void Block()
    {
        if (Input.GetMouseButtonDown(1) /**&& isGrounded**/) //mouse button down 1 = Right mouse button
        {
            anim.SetInteger("condition", 3); // condition 6 = blocking animation.
        }
    }

    void Run()
    {
        if (Input.GetKey(KeyCode.LeftShift) /**&& isGrounded**/) // run when leftshift is pressed
        {
            float x = Input.GetAxis("Horizontal");
            float z = Input.GetAxis("Vertical");
            Vector3 move = transform.right * x + transform.forward * z;
            speed = 15f;
            controller.Move(move * speed * Time.deltaTime); //increase speed when left shift is pressed
            anim.SetInteger("condition", 4); // condition 4 = running
        }
    }

    void crouch()
    {
        if (Input.GetKey(KeyCode.LeftControl) /**&& isGrounded**/) // crouch when leftcontrol is pressed
        {
            anim.SetInteger("condition", 5); // condition 5 = crouching

        }
    }

    //void TakeDamage(int damage)
    //{
       // currentHealth -= damage;
      //  healthBar.SetHealth(currentHealth);
  //  }
}
