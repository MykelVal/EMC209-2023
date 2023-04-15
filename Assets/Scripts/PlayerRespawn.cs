using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    private Transform _spawnLocation;
    private GameObject _spawnObject;

    private void Start()
    {
        _spawnObject = GameObject.Find("Spawn");
        _spawnLocation = _spawnObject.GetComponent<Transform>();
    }

    public void Respawn(Transform playerLocation)
    {
        playerLocation.position = _spawnLocation.position;
    }
}
