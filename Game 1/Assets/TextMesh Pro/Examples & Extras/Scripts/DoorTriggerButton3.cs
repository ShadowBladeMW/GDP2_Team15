using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton3 : MonoBehaviour
{
    [SerializeField] private DoorSetActive3 door; 

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.K)){
            door.OpenDoor();
        }
    }
}
