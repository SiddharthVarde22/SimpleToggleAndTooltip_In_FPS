using UnityEngine;

public class ServiceLocator : GenericSingleton<ServiceLocator>
{
    public bool isObject1Red { get; set; }
    public bool isObject2Rotating { get; set; }

    public EventService eventService;

    protected override void Awake()
    {
        base.Awake();
        eventService = new EventService();
    }
}
