using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FapGameScore : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        CromGameManager manager1;
        GameObject temp;
        temp = GameObject.Find("Game Manager");
        manager1 = temp.GetComponent<CromGameManager>();

        manager1.cromScoreInc();
            
    }
}
