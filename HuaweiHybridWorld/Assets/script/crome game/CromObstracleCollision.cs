using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromObstracleCollision : MonoBehaviour
{
    private  CromGameManager gameManager;
    private GameObject gameobject3;

    private void Start()
    {
        gameobject3 = GameObject.Find("Game Manager");
        gameManager = gameobject3.GetComponent<CromGameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        gameManager.cromGameover();
    }
}
