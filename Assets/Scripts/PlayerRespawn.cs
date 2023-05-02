using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRespawn : MonoBehaviour
{
    public float minYLevel = -10f; 
    public Transform respawnPoint; 

    void Update()
    {
        if (transform.position.y < minYLevel)
        {
            Respawn();
        }
    }

    void Respawn()
    {
        transform.position = respawnPoint.position; 
        transform.rotation = respawnPoint.rotation; 
        GetComponent<Rigidbody>().velocity = Vector3.zero; 
    }
}
