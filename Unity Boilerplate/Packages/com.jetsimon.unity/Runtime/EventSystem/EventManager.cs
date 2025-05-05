using System;
using System.Collections.Generic;

namespace Boilerplate.Managers.EventSystem
{
    /// <summary>
    /// Event bus system
    /// </summary>
    public class EventManager
    {
        private static Dictionary<Type, List<Delegate>> m_handlers = new();
        
        public static void AddEventListener<T>(Action<T> action) where T : EventBase
        {
            Type type = typeof(T);
            if (!m_handlers.ContainsKey(type))
            {
                m_handlers.Add(type, new List<Delegate>());
            }
            m_handlers[type].Add(action);
        }
        
        public static void RemoveEventListener<T>(Action<T> action) where T : EventBase
        {
            Type type = typeof(T);
            if (!m_handlers.ContainsKey(type))
            {
                return;
            }
            m_handlers[type].Remove(action);
        }
        
        public static void TriggerEvent<T>(T eventData) where T : EventBase
        {
            Type type = typeof(T);
            if (!m_handlers.ContainsKey(type))
            {
                return;
            }

            foreach (Delegate d in m_handlers[type])
            {
                d.Method.Invoke(d.Target, new object[] { eventData });
            }
        }
    }
}
