using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerScript : MonoBehaviour
{
    public float MoveSpeed;
    public Vector3 MoveDirection;
    public Vector3 velocity;
    

    public bool IsGrounded;
    public float GroundCheckDistance;
    public LayerMask GroundMask;
    public float Gravity;
    public float JumpHeight;



    public CharacterController controller;
    public Animator anim;
    public FixedJoystick joystick;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

    }

    public void Move()
    {
        IsGrounded = Physics.CheckSphere(transform.position, GroundCheckDistance, GroundMask);
        if (IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        
        MoveDirection = new Vector3(joystick.Horizontal, 0, joystick.Vertical);
        MoveDirection = transform.TransformDirection(MoveDirection);

        MoveDirection *= MoveSpeed;
        //===========================================================

       

        controller.Move(MoveDirection * Time.deltaTime);
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);


    }
   

    public void Jump()
    {
        velocity.y = Mathf.Sqrt(JumpHeight * -2 * Gravity);
        anim.SetTrigger("jump");
    }
   

}
