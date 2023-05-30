using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tryckapafargerna : MonoBehaviour, IInteractable
{
    private Renderer renderer; // Anv�nd "Renderer" ist�llet f�r "r" f�r tydlighet
    private Color originalColor; // F�r att spara det ursprungliga f�rgv�rdet
    public int thisButtonNumber;

    private startaspelet thestart;

    private AudioSource theSound;

    private Vector3 originalPosition;
    private bool buttonpressed = false;


    void Start()
    {
        renderer = GetComponent<Renderer>();
        originalColor = renderer.material.color;
        thestart = FindAnyObjectByType<startaspelet>();
        theSound = GetComponent<AudioSource>();
        originalPosition = gameObject.transform.localPosition;
    }

    public void Interact()
    {  
        if(buttonpressed == false)
        { 
        renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 1f);
        theSound.Play();
        gameObject.transform.localPosition = originalPosition - new Vector3(0, 0.2f, 0);
        buttonpressed = true;
        }

    }

    public void DeInteract()
    {
        if (buttonpressed == true)
        { 
        renderer.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
        theSound.Stop();
        gameObject.transform.localPosition = originalPosition + new Vector3(0, 0.1f, 0);
        thestart.knapptryckt(thisButtonNumber);
        buttonpressed = false;
        }
    }
}