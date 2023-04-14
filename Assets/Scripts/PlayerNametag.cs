using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;

public class PlayerNametag : MonoBehaviourPunCallbacks
{
    [SerializeField] TextMeshPro _playerName;
    [SerializeField] PhotonView _playerPhotonView;

    private void Start()
    {

    }

    void Update()
    {
        // Update the position of the nametag to be above the player's head
        transform.position = photonView.transform.position + Vector3.up * 2f;

        // Update the position of the nametag to be above the player's head
        //transform.position = photonView.transform.position + Vector3.back * 0.1f + Vector3.up * 0.5f; // Adjust z-offset and y-offset as needed


        // Update the text of the nametag to show the player's name
        _playerName.text = photonView.Owner.NickName;
    }
}
