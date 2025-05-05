using System.Collections;
using System.Collections.Generic;
using Boilerplate.Managers.EventSystem;
using UnityEngine;

public class TestEvent : EventBase
{
    public string Payload = "Test";
}

public class EventSystemTest : MonoBehaviour
{
    
    private void Awake()
    {
        EventManager.AddEventListener<TestEvent>(OnTestEvent);
    }

    private void OnDestroy()
    {
        EventManager.RemoveEventListener<TestEvent>(OnTestEvent);
    }

    private void Start()
    {
        EventManager.TriggerEvent(new TestEvent());
    }

    private void OnTestEvent(TestEvent e)
    {
        Debug.Log(e.Payload);
    }
}
