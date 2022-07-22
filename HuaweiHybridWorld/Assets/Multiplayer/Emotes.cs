using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Emotes : MonoBehaviour
{

    PhotonView view;
    [SerializeField] private CharacterControllerScript animator;


    // Update is called once per frame
    void Update()
    {
        if(view.IsMine)
        {
            animator.anim.SetTrigger("");
        }
    }

    private void chagneEmote()
    {
            
    }
}
