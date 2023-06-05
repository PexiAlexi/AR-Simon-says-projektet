using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tryckapafargerna : MonoBehaviour, IInteractable
{
    private Renderer r; // Anv�nd "Renderer" ist�llet f�r "r" f�r tydlighet
    private Color originalColor; // F�r att spara det ursprungliga f�rgv�rdet
    public int thisButtonNumber;

    private startaspelet thestart;

    private AudioSource theSound;

    private Vector3 originalPosition;


    void Start()
    {
        r = GetComponent<Renderer>();
        originalColor = r.material.color;
        thestart = FindAnyObjectByType<startaspelet>();
        theSound = GetComponent<AudioSource>();
        originalPosition = gameObject.transform.localPosition;
    }

    public void Interact()
    {
        
            r.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 1f);
            theSound.Play();
            gameObject.transform.localPosition = originalPosition - new Vector3(0, 0.2f, 0);         
    }

    public void DeInteract()
    {
            thestart.knapptryckt(thisButtonNumber);
            r.material.color = new Color(originalColor.r, originalColor.g, originalColor.b, 0.5f);
            theSound.Stop();
            gameObject.transform.localPosition = originalPosition + new Vector3(0, 0.1f, 0);
            
    }
}