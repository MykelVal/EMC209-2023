using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    [SerializeField] private Transform _spawnLocation;
    public void Respawn(Transform playerLocation)
    {
        playerLocation = _spawnLocation;
    }
}
