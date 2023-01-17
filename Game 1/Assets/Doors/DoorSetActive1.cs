using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorSetActive1 : MonoBehaviour
{
    // Start is called before the first frame update
    public void OpenDoor()
    {
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    public void CloseDoor()
    {
        gameObject.SetActive(true);
    }
}
