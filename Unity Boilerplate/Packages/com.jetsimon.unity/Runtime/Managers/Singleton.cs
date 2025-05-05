using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Boilerplate.Managers
{
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        public static T Instance { get; private set; }

        public virtual void Awake()
        {
            if (Instance == null)
            {
                Instance = this as T;
            }
            else
            {
                Debug.LogWarning($"Singleton of type {GetType()} already exists. Destroying.");
                Destroy(this);
            }
        }

        public virtual void OnDestroy()
        {
            if (Instance == this)
            {
                Instance = null;
            }
        }
    }
}

