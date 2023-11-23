using System;

public class EventService
{
    public event Action<string> OnMouseEnterEvent;
    public event Action OnMouseExitEvent;

    public void OnMouseEnterEventCalled(string toolTipToShow)
    {
        OnMouseEnterEvent?.Invoke(toolTipToShow);
    }

    public void OnMouseExitEventCalled()
    {
        OnMouseExitEvent?.Invoke();
    }
}
