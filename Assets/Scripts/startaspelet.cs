using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startaspelet : MonoBehaviour, IInteractable
{
    private GamemanagerAR gameManager;

    private void Start()
    {
        // Hitta GamemanagerAR-objektet och lagra referensen
        gameManager = FindObjectOfType<GamemanagerAR>();
    }

    public void Interact()
    {
        if (gameManager != null)
        {
            // Kör StartGame() från GamemanagerAR-objektet
            gameManager.StartGame();
        }
    }
}