using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ObstacleBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        // Check if the collided object is the local player
        if (other.gameObject.GetComponent<PhotonView>().IsMine)
        {
            // Call a method on the player object to respawn it
            other.gameObject.GetComponent<PlayerRespawn>().Respawn(other.gameObject.GetComponent<Transform>());
        }
    }
}
