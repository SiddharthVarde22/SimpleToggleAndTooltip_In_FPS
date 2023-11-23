using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object3_Interactable : ObjectInteraction
{
    [SerializeField]
    Vector3 origionalSize = Vector3.one, increasedSize = Vector3.one * 2;

    bool isExpanded = false;

    public override void OnInteractingWithObject()
    {
        if (CheckIfCanExpand())
        {
            ToggleObjectSize();
        }
    }

    private void ToggleObjectSize()
    {
        if(isExpanded)
        {
            transform.localScale = origionalSize;
            isExpanded = false;
        }
        else
        {
            transform.localScale = increasedSize;
            isExpanded = true;
        }
    }

    private bool CheckIfCanExpand()
    {
        if(isExpanded)
        {
            return true;
        }

        return (!ServiceLocator.Instance.isObject1Red && !ServiceLocator.Instance.isObject2Rotating);
    }
}
