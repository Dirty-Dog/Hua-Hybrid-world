using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FapBIrdScore : MonoBehaviour
{
    public FapBirdGameManager Score;
    public GameObject gameObject2;

    private void Start()
    {
        gameObject2 = GameObject.Find("GameManager");
        Score =gameObject2.GetComponent<FapBirdGameManager>();
    }
    private void OnTriggerExit(Collider other)
    {
        Score.scoreInc();
    }

}
