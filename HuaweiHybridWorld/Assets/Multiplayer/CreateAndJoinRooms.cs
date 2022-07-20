using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Photon.Pun;

public class CreateAndJoinRooms : MonoBehaviourPunCallbacks
{

    public TMP_InputField createInput;
    public TMP_InputField joinInput;

    public void CreateRoom()
    {
        Photon.Realtime.RoomOptions ro = new Photon.Realtime.RoomOptions() {MaxPlayers = 5 };
        if (createInput.text.Length >= 1)
        {
            PhotonNetwork.CreateRoom(createInput.text, ro );
        }
        
        

    }

    public void joinRoom()
    {
      
        PhotonNetwork.JoinRoom(joinInput.text);

    }

    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Lobby");
    }
}
