using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstracleSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1, timer = 0 , height, obstracleDestroy;
    [SerializeField] private GameObject obstracle;
    

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newObstracle = Instantiate(obstracle);
            newObstracle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newObstracle, obstracleDestroy);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
