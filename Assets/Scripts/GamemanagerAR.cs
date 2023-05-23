using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;



public class GamemanagerAR : MonoBehaviour
{
    public Material[] fargknapparna;

    private int knappSelect;

    public float stayLit;
    private float stayLitCounter;
    public void StartGame()
    {
       
        knappSelect = Random.Range(0, fargknapparna.Length);
        fargknapparna[knappSelect].EnableKeyword("_EMISSION");

        stayLitCounter = stayLit;

    }


    private void OnEnable()
    {
        LeanTouch.OnFingerDown += LeanTouch_OnFingerDown;
    }

    private void OnDisable()
    {
        LeanTouch.OnFingerDown -= LeanTouch_OnFingerDown;
    }

    private void LeanTouch_OnFingerDown(LeanFinger obj)
    {

    
        Vector3 screenPos = new Vector3(obj.ScreenPosition.x, obj.ScreenPosition.y, Camera.main.nearClipPlane);


        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            IInteractable interactableObj = hitObject.gameObject.GetComponent<IInteractable>();

            if (interactableObj != null)
            {
                interactableObj.Interact();
            }
        }


    }

    private void Update()
    {
        if(stayLitCounter > 0)
        {

            stayLitCounter -= Time.deltaTime;
        }
        else
        {
            fargknapparna[knappSelect].DisableKeyword("_EMISSION");

        }
    }


}