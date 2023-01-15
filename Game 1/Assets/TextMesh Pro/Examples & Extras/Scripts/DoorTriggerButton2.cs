using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerButton2 : MonoBehaviour
{
    [SerializeField] private DoorSetActive2 door2; 

    // Update is called once per frame
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.G)){
            door2.OpenDoor();
        }
    }
}
