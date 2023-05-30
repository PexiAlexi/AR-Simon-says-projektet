using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tryckapafargerna : MonoBehaviour, IInteractable
{
    private Renderer renderer; // Använd "Renderer" istället för "r" för tydlighet
    private Color originalColor; // För att spara det ursprungliga färgvärdet
    public int thisButtonNumber;

    private startaspelet thestart;

    private AudioSource theSound;


    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
        thestart = FindAnyObjectByType<startaspelet>();
        theSound = GetComponent<AudioSource>();
    }

    public void Interact()
    {
        renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 1f);
        theSound.Play();
    }

    public void DeInteract()
    {
        renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
        thestart.knapptryckt(thisButtonNumber);
        theSound.Stop();
    }
}