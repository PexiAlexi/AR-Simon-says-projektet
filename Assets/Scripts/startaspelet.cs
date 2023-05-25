using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AugmentedRealityCourse;

public class startaspelet : MonoBehaviour, IInteractable
{
    public Material[] fargknapparna;
    private int knappSelect;

    public float stayLit;
    private float stayLitCounter;


    public void Interact()
    {

        knappSelect = Random.Range(0, fargknapparna.Length);
        fargknapparna[knappSelect].color = new Color(fargknapparna[knappSelect].color.r, fargknapparna[knappSelect].color.g, fargknapparna[knappSelect].color.b, 1f);

        stayLitCounter = stayLit;

        DebugManager.Instance.AddDebugMessage("Träff");

    }

    private void Update()
    {
        if (stayLitCounter > 0)
        {

            stayLitCounter -= Time.deltaTime;
        }
        else
        {
             fargknapparna[knappSelect].color = new Color(fargknapparna[knappSelect].color.r, fargknapparna[knappSelect].color.g, fargknapparna[knappSelect].color.b, 0.5f);

        }
    }
}