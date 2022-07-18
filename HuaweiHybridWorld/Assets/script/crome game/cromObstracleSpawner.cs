using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cromObstracleSpawner : MonoBehaviour
{
    [SerializeField] private float maxTime = 1, timer = 0, height, obstracleDestroy;
    [SerializeField] private GameObject[] obstracle;
    private int obstracleNo;
    private void Start()
    {
        obstracleNo = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime)
        {
            obstracleNo = Random.Range(0,obstracle.Length);
            GameObject newObstracle = Instantiate(obstracle[obstracleNo]);
            newObstracle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newObstracle, obstracleDestroy);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
  