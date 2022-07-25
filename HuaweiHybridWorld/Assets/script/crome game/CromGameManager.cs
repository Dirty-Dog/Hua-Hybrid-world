using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CromGameManager : MonoBehaviour
{
    public void cromGameover()
    {
        if(gameObject.CompareTag("enemy"))
        //pause game
        Debug.Log("game over");
        Time.timeScale = 0;

        //show score 
    }
}
