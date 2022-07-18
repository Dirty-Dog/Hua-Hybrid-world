using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromObstracleMove : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        this.transform.Translate(Vector3.forward*speed);
    }
}
