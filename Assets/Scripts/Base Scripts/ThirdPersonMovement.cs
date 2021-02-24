using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement : MonoBehaviour
{

    public GameObject characterModel;
    public CharacterController controller;
    public Transform cam;

    private float speed;
    public float walkSpeed = 6f;
    public float runSpeed = 12f;

    public float gravity = -9.81f;
    public float yVelocityReset = -2f;

    public float jump = 10f;
    public float killFallDist = 30f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    Vector3 velocity;
    bool isGrounded;
    public bool shouldDie = false;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    string animState = "Idle";
    Animator anim;

    bool moving = false;

    bool fallMeasured = false;
    float startFall;
    float endFall;
    float fallDist;

    public bool playerIsControllable = true;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        
        //lock da' cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }


    // Update is called once per frame
    void Update()
    {
        //reset all animations to false
        #region
        anim.SetBool("IsWalking", false);
        anim.SetBool("IsRunning", false);
        anim.SetBool("IsJumping", false);
        anim.SetBool("Idle", false);
        moving = false;
        #endregion

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
    /*
        //fall damage check
        #region
        //checks the y position the player is at when they fall
        if (!isGrounded && !fallMeasured)
        {
            fallMeasured = true;
            startFall = groundCheck.position.y;
        }
        //called once the player lands again
        if (isGrounded && fallMeasured)
        {
            fallMeasured = false;
            endFall = groundCheck.position.y;
            //fall equation
            fallDist = Mathf.Abs(Mathf.Abs(startFall) - Mathf.Abs(endFall));
            //if the fall distance was enough to kill, kill.
            if (fallDist > killFallDist)
            {
                die();
            }

        }
        #endregion
        */

        //set velocity to a small value when the player is grounded
        if (isGrounded && velocity.y < 0)
        {
            velocity.y = yVelocityReset;
        }


        //jump thing
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y += jump;
            moving = true;
            bool jumping = true;
            anim.SetBool("IsJumping", jumping);
        }
        //jump anim backup
        if (!isGrounded)
        {
            bool jumping = true;
            anim.SetBool("IsJumping", jumping);
        }



        //Create a vector3 named 'direction' based on your movement inputs
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        //change speed (and animation!) based on if the player is pressing down sprint key
        if (horizontal > 0.01f || horizontal < -0.1f || vertical > 0.01f || vertical < -0.1f && isGrounded)
        {
            moving = true;
            if (Input.GetButton("Sprint"))
            {
                speed = runSpeed;
                bool running = true;
                anim.SetBool("IsRunning", running);
            }
            else
            {
                speed = walkSpeed;
                bool walking = true;
                anim.SetBool("IsWalking", walking);
            }
        }

        //idle
        if (!moving)
        {
            bool Idle = true;
            anim.SetBool("Idle", Idle);
        }

        //if the movement is noticable, do movement calculations
        if (direction.magnitude >= 0.1f && playerIsControllable)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);
        }



        //gravity thing
        velocity.y += gravity * Time.deltaTime * Time.deltaTime;

        //move the player if she's controllable
        if (playerIsControllable)
        {
            controller.Move(velocity);
        }
        if (shouldDie && isGrounded)
        {
            die();
        }
    }

    void die()
    {
        anim.SetTrigger("Die");
        playerIsControllable = false;
        Debug.Log("you died");
    }

}
