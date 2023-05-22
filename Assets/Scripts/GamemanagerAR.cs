using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;



public class GamemanagerAR : MonoBehaviour
{

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


}