using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton1 : MonoBehaviour
{
    [SerializeField] private DoorSetActive1 door; 

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)){
            door.OpenDoor();
        }
    }
}
