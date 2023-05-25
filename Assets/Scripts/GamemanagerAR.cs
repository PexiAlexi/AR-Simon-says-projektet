using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;
using AugmentedRealityCourse;


public class GamemanagerAR : MonoBehaviour
{
   

    private void OnEnable()
    {
        LeanTouch.OnFingerDown += LeanTouch_OnFingerDown;
        LeanTouch.OnFingerUp += LeanTouch_OnFingerUp;
    }

    private void OnDisable()
    {
        LeanTouch.OnFingerDown -= LeanTouch_OnFingerDown;
        LeanTouch.OnFingerUp -= LeanTouch_OnFingerUp;
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

    private void LeanTouch_OnFingerUp(LeanFinger obj)
    {


        Vector3 screenPos = new Vector3(obj.ScreenPosition.x, obj.ScreenPosition.y, Camera.main.nearClipPlane);


        Ray ray = Camera.main.ScreenPointToRay(screenPos);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            GameObject hitObject = hit.collider.gameObject;

            IInteractable2 interactableObj2 = hitObject.gameObject.GetComponent<IInteractable2>();

            if (interactableObj2 != null)
            {
                interactableObj2.Interact2();
            }
        }


    }


}