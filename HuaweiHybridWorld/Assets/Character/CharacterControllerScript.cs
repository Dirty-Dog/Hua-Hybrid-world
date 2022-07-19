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

    public GameObject camrea;
    public Transform playerTransform;
    public float camX,camY,Xsen,Ysen;



    public CharacterController controller;
    public Animator anim;
    public FixedJoystick joystick ;
    public DynamicJoystick freeLookJoyStick;

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
        camRotation();
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
        
        if (joystick.Vertical > 0)
        {
            anim.SetFloat("Speed", 2, 0.05f, Time.deltaTime);
        }

        else if (joystick.Vertical < 0)
        {
            anim.SetFloat("Speed", 0, 0.05f, Time.deltaTime);
        }

        else if (joystick.Vertical == 0)
        {
            anim.SetFloat("Speed", 1, 0.05f, Time.deltaTime);
        }

        else
        {
            anim.SetFloat("Speed", 0, 0.05f, Time.deltaTime);
        }
       

        controller.Move(MoveDirection * Time.deltaTime);
        velocity.y += Gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);


    }

    public void camRotation()
    {
        camY +=freeLookJoyStick.Horizontal;
        camX -= freeLookJoyStick.Vertical;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, camY * Ysen, 0));
        camrea.transform.rotation = Quaternion.Euler(new Vector3(camX * Xsen, 0, 0));
        camrea.transform.LookAt(playerTransform);
        
        
    }


    public void Jump()
    {
        velocity.y = Mathf.Sqrt(JumpHeight * -2 * Gravity);
        anim.SetTrigger("jump");
    }
   

}
