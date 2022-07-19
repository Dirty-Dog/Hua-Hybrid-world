using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public TMP_InputField createInput;
    
   public void CreateRoom()
    {
        PhotonNetwork.CreateRoom(createInput.text);

    }

    public void joinRoom()
    {
        PhotonNetwork.JoinRoom(createInput.text);

    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Lobby");
    }
}
