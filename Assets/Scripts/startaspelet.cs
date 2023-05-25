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

    public float waitBetweenLights;
    private float waitBetweenCounter;

    private bool shouldBeLit;
    private bool shouldBeDark;

    public List<int> activeSquence;
    private int postionInSequnce;

    private bool gameActive;
    private int InputInsequence;

    private Renderer r;
    public void Interact()
    {
        activeSquence.Clear();

        postionInSequnce = 0;
        InputInsequence = 0;

        knappSelect = Random.Range(0, fargknapparna.Length);

        activeSquence.Add(knappSelect);
       
        r = fargknapparna[activeSquence[postionInSequnce]].GetComponent<Renderer>();
        r.material.color = new Color(r.material.color.r, r.material.color.g, r.material.color.b, 1f);
        stayLitCounter = stayLit;
        shouldBeLit = true;
        

    }

    private void Update()
    {
        if (shouldBeLit)
        {

            stayLitCounter -= Time.deltaTime;
        
       
            if(stayLitCounter < 0)
            { 
                r.material.color = new Color(r.material.color.r, r.material.color.g, r.material.color.b, 0.5f);
                shouldBeLit = false;

                shouldBeDark = true;
                waitBetweenCounter = waitBetweenLights;

                postionInSequnce++;
            }
        }

        if (shouldBeDark)
        {

            waitBetweenCounter -= Time.deltaTime;

            if(postionInSequnce >= activeSquence.Count)
            {

                shouldBeDark = false;
                gameActive = true;
            }

            else

            {
                if(waitBetweenCounter < 0)
                {
                    

                    r = fargknapparna[activeSquence[postionInSequnce]].GetComponent<Renderer>();
                    r.material.color = new Color(r.material.color.r, r.material.color.g, r.material.color.b, 1f);
                    stayLitCounter = stayLit;
                    shouldBeLit = true;
                    shouldBeDark = false;

                }

            }
        }

    }

    public void DeInteract()
    {

    }

    public void knapptryckt(int whichButton)
    {
        if(gameActive)
        { 
        
                if(activeSquence[InputInsequence] == whichButton)
                {

                    DebugManager.Instance.AddDebugMessage("Korrekt!");

                    InputInsequence++;

                    if(InputInsequence >= activeSquence.Count)
                    {
                        postionInSequnce = 0;
                        InputInsequence = 0;

                        knappSelect = Random.Range(0, fargknapparna.Length);

                        activeSquence.Add(knappSelect);

                        r = fargknapparna[activeSquence[postionInSequnce]].GetComponent<Renderer>();
                        r.material.color = new Color(r.material.color.r, r.material.color.g, r.material.color.b, 1f);
                        stayLitCounter = stayLit;
                        shouldBeLit = true;

                        gameActive = false;
                    }

                }

                else
                {

                    DebugManager.Instance.AddDebugMessage("FEL!");
                    gameActive = false;
                }
        }
    }
}