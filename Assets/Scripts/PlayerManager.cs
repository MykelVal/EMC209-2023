using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField] private Transform _spawnLocation;

    [SerializeField] private GameObject _playerPrefab;
    
    // Start is called before the first frame update
    void Start()
    {
        PhotonNetwork.Instantiate("Characters/Player", _spawnLocation.position, Quaternion.identity);
    }

    public void Respawn(Transform playerLocation)
    {
        playerLocation.position = _spawnLocation.position;
    }
}
