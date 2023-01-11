using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, Iinteractible
{
    [SerializeField] private string _prompt;
    
    public string InteractionPrompt => _prompt;

    public bool Interact(Interactor interactor)
    {
        Debug.Log(message:"Obtaining item!");
        return true;
    }
}
