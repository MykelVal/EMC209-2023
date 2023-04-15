using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;

public class ExitLobby : MonoBehaviour
{
    [SerializeField] private Button _leaveRoom;

    private void OnEnable()
    {
        _leaveRoom.onClick.AddListener(LeaveRoom);
    }

    private void OnDisable()
    {
        _leaveRoom.onClick.RemoveListener(LeaveRoom);
    }

    private void LeaveRoom()
    {
        PhotonNetwork.LeaveRoom();
        PhotonNetwork.LoadLevel(1);
    }
}

