using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changebacktomenuscript : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        Application.Quit();
    }

    public void DeInteract()

    {
        
    }
}
