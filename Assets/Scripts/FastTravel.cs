using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FastTravel : MonoBehaviour
{
    // Variables
    //public GameObject player;
    public GameObject fastTravelUI;
    //Start
    void Start() {
        fastTravelUI.SetActive(false);
    }

    void OnTriggerEnter (Collider player) {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        
        fastTravelUI.SetActive(true);
    }
}
