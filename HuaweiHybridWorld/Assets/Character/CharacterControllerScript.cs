using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

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
    public GameObject canvas;
   
    
    public Transform playerTransform;
    public float camX,camY,Xsen,Ysen;



    public CharacterController controller;
    public Animator anim;
    public FixedJoystick joystick ;
    public FixedJoystick freeLookJoyStick;
    public float xclampped;



    PhotonView view;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponentInChildren<Animator>();
        view = GetComponent<PhotonView>();

      
            
    }

    // Update is called once per frame
    void Update()
    {
        if (view.IsMine)
        {
            camrea.SetActive(true);
            canvas.SetActive(true);
            
            
            Move();
            
        }
        
    }

    void LateUpdate()
    {
        if (view.IsMine)
        {
            camRotation();
        }

    }

    public void Move()
    {
        IsGrounded = Physics.CheckSphere(transform.position, GroundCheckDistance, GroundMask);
        if (IsGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        
        MoveDirection = new Vector3(joystick.Horizontal*0.5f, 0, joystick.Vertical);
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
        if(camX > 10)
        {
            camX = 10;
        }
        if (camX < -10)
        {
            camX = -10;
        }
        if (camY > 1000)
        {
            camY =0;
        }
        if (camY < -1000)
        {
            camY =0;
        }

        xclampped = Mathf.Clamp(camX, -10, 10);
        this.transform.rotation = Quaternion.Euler(new Vector3(0, camY * Ysen, 0));

        camrea.transform.rotation = Quaternion.Euler(new Vector3(xclampped * Xsen, camY * Ysen, 0));
        
        
        
    }


    
   

}
