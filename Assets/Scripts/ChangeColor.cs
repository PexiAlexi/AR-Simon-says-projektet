using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour, IInteractable
{
    [SerializeField]
    private Color color;
    public void Interact()
    {
        Renderer r = gameObject.GetComponent<Renderer>();
        r.material.color = color;
    }
}
