using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object1_Interactable : ObjectInteraction
{
    [SerializeField]
    Color colorRed = Color.red, colorGreen = Color.green;

    bool isRed = true;

    [SerializeField]
    Material material;

    private void Start()
    {
        ServiceLocator.Instance.isObject1Red = isRed;
    }

    public override void OnInteractingWithObject()
    {
        ToggleColorChange();
    }

    private void ToggleColorChange()
    {
        if(isRed == true)
        {
            material.color = colorGreen;
            isRed = false;
        }
        else
        {
            material.color = colorRed;
            isRed = true;
        }

        ServiceLocator.Instance.isObject1Red = isRed;
    }

    private void OnDestroy()
    {
        material.color = colorRed;
    }
}
