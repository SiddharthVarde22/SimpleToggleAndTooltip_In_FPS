using UnityEngine;
using TMPro;

public class TooltipBehavior : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI tooltipText;

    private void Start()
    {
        ServiceLocator.Instance.eventService.OnMouseEnterEvent += OnTooltipActivate;
        ServiceLocator.Instance.eventService.OnMouseExitEvent += OnTooltipDeactivate;
    }

    public void OnTooltipActivate(string tooltipToShow)
    {
        tooltipText.text = tooltipToShow;
        tooltipText.gameObject.SetActive(true);
    }

    public void OnTooltipDeactivate()
    {
        tooltipText.gameObject.SetActive(false);
    }

    private void OnDestroy()
    {
        ServiceLocator.Instance.eventService.OnMouseEnterEvent -= OnTooltipActivate;
        ServiceLocator.Instance.eventService.OnMouseExitEvent -= OnTooltipDeactivate;
    }
}
