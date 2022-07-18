using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colliderScript : MonoBehaviour
{
    [SerializeField] private GameObject gameObject1;
    [SerializeField] private FapBirdGameManager gameManager;

    private void Start()
    {
       gameObject1 = GameObject.Find("GameManager");
       gameManager = gameObject1.GetComponent<FapBirdGameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        gameManager.gameOver();
    }

    
}
