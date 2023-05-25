using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tryckapafargerna : MonoBehaviour, IInteractable, IInteractable2
{
    private Renderer renderer; // Anv�nd "Renderer" ist�llet f�r "r" f�r tydlighet
    private Color originalColor; // F�r att spara det ursprungliga f�rgv�rdet

    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
    }

    public void Interact()
    {
        renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 1f);
    }

    public void Interact2()
    {
        renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
    }
}