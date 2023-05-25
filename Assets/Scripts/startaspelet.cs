using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AugmentedRealityCourse;

public class startaspelet : MonoBehaviour, IInteractable
{
    public GameObject[] fargknapparna;
    private int knappSelect;

    public float stayLit;
    private float stayLitCounter;

    private Renderer r;
    public void Interact()
    {

        knappSelect = Random.Range(0, fargknapparna.Length);
        //fargknapparna[knappSelect].color = new Color(fargknapparna[knappSelect].color.r, fargknapparna[knappSelect].color.g, fargknapparna[knappSelect].color.b, 1f);
        r = fargknapparna[knappSelect].GetComponent<Renderer>();
        r.material.color = new Color(r.material.color.r, r.material.color.g, r.material.color.b, 1f);
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
            //fargknapparna[knappSelect].color = new Color(fargknapparna[knappSelect].color.r, fargknapparna[knappSelect].color.g, fargknapparna[knappSelect].color.b, 0.5f);
            r.material.color = new Color(r.material.color.r, r.material.color.g, r.material.color.b, 0.5f);
        }
    }
}