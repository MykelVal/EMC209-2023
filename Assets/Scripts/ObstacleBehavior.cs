using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ObstacleBehavior : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("entered");
        // Check if the collided object is the local player
        if (other.gameObject.GetComponent<PhotonView>().IsMine)
        {
            // Call a method on the player object to respawn it
            Debug.Log("ded");
        }
    }
}
