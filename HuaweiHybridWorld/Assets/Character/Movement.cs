using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float horizontalSpeed = 1.0F;
    public float verticalSpeed = 1.0F;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Rigidbody rb = GetComponent<Rigidbody>();
        if (Input.GetKey(KeyCode.A))
            rb.velocity = transform.TransformDirection(new Vector3(-30, 0, 0));
        else if (Input.GetKey(KeyCode.D))
            rb.velocity = transform.TransformDirection(new Vector3(30, 0, 0));
        else if (Input.GetKey(KeyCode.W))
            rb.velocity = transform.TransformDirection(new Vector3(0, 0, 30));
        else if (Input.GetKey(KeyCode.S))
            rb.velocity = transform.TransformDirection(new Vector3(0, 0, -30));

        else
        {
            rb.velocity = new Vector3(0, 0,0);
        }
            




        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        float v = verticalSpeed * Input.GetAxis("Mouse Y");
        transform.Rotate(-v, h, 0);
    }
}
