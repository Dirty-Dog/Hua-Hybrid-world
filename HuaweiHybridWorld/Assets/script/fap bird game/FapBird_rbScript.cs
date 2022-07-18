using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FapBird_rbScript : MonoBehaviour
{
    [SerializeField] private float thrust;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            rb.AddForce(0, thrust,0, ForceMode.Impulse);
        }
    }
}
