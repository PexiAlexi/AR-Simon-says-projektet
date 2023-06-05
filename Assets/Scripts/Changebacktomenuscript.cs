using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changebacktomenuscript : MonoBehaviour, IInteractable
{
    public string menuSceneName = "Startscean";
    public void Interact()
    {
        SceneManager.LoadScene(menuSceneName);
    }

    public void DeInteract()

    {
        
    }
}
