using System;
using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityEngine.UI;

public class CreateRoomPanel : MonoBehaviour
{
    [SerializeField] private InputField _roomName;
    [SerializeField] private Button _createBtn;

    [SerializeField] private CurrencyManager _currencyManager;

    private void OnEnable()
    {
        _createBtn.onClick.AddListener(CreateRoom);        
    }

    private void OnDisable()
    {
        _roomName.text = "";
        _createBtn.onClick.RemoveAllListeners();
    }

    private void CreateRoom()
    {
        if (_currencyManager.HasEnoughEnergy(1))
        {
            if (!string.IsNullOrEmpty(_roomName.text))
            {
                PhotonNetwork.CreateRoom(_roomName.text, new RoomOptions() { MaxPlayers = 4 });
            }
        }
        else
        {
            Debug.Log("Not enough energy");
        }
        
    }
}
