using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
public class Emotes : MonoBehaviour
{

    [SerializeField] private PhotonView view;
    [SerializeField] private CharacterControllerScript animator;
    

    public void chagneEmote(int a)
    {

        if (view.IsMine)
        {
            string animtionName = a.ToString();
            animator.anim.SetTrigger(animtionName);
            Debug.Log(animtionName);
        }
    }
}
