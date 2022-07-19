using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject playerPrefab;


    public int SpawnedLocs;
    public Vector3 SpawnLocation;

    // Update is called once per frame
    void Start()
    {
        SpawnLocation = transform.position;
        PhotonNetwork.Instantiate(playerPrefab.name, SpawnLocation, Quaternion.identity);
    }
}
