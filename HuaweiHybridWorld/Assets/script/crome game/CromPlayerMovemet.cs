using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromPlayerMovemet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] private float thrust;
    [SerializeField] private bool isGrounded;
    [SerializeField]private float groundCheckDistance;
    [SerializeField]private LayerMask groundMask;

    void Start()
    {
        rb=this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, groundCheckDistance, groundMask);
        

        if (Input.GetMouseButtonDown(0) && isGrounded)
        {
            rb.AddForce(0, thrust, 0, ForceMode.Impulse);
        }
    }

    
}
