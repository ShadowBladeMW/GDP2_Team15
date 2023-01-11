using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Interactor : MonoBehaviour
{
    [SerializeField] private Transform _interactionPoint;
    [SerializeField] private float _interactionPointRadius = 0.5f;
    [SerializeField] private LayerMask _interactableMask;

    private Collider2D _collider;

    private void Update()
    {
        _collider = Physics2D.OverlapCircle(_interactionPoint.position, 
        _interactionPointRadius, _interactableMask);
        if (_collider != null)
        {
            var interactible = _collider.GetComponent<Iinteractible>();

            if (interactible != null && Keyboard.current.eKey.wasPressedThisFrame)
            {
                interactible.Interact(this);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(_interactionPoint.position, _interactionPointRadius);
    }
}

