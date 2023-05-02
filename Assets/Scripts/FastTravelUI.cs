using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FastTravelUI : MonoBehaviour
{
    public GameObject self;
    public GameObject player;
    
    /* Public Functions */

    public void teleportToLocation(Transform locationNumber) {
        player.transform.position = locationNumber.position;
        // CloseMenu();
    }

    public void CloseMenu() {
        self.SetActive(false);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
