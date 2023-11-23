using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object2_Interactable : ObjectInteraction
{
    [SerializeField]
    float rotationSpeed = 20;

    bool isRotating = false;

    private void Start()
    {
        ServiceLocator.Instance.isObject2Rotating = isRotating;
    }

    public override void OnInteractingWithObject()
    {
        ToggleObjectRotation();
    }

    private void ToggleObjectRotation()
    {
        isRotating = !isRotating;
        ServiceLocator.Instance.isObject2Rotating = isRotating;
    }

    private void Update()
    {
        if(isRotating)
        {
            transform.rotation *= Quaternion.Euler(0, 0, rotationSpeed * Time.deltaTime);
        }
    }
}
