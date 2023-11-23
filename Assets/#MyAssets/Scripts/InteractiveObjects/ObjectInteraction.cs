using UnityEngine;

public abstract class ObjectInteraction : MonoBehaviour
{
    [SerializeField]
    protected string toolTipToShow;

    protected void OnMouseEnter()
    {
        ServiceLocator.Instance.eventService.OnMouseEnterEventCalled(toolTipToShow);
    }

    protected void OnMouseExit()
    {
        ServiceLocator.Instance.eventService.OnMouseExitEventCalled();
    }

    protected void OnMouseDown()
    {
        OnInteractingWithObject();
    }

    public abstract void OnInteractingWithObject();
}
