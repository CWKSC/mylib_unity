using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Reference : http://wiki.unity3d.com/index.php/Singleton

// Have some modify, add " public abstract void Init(); "

/// <summary>
/// Inherit from this base class to create a singleton.
/// e.g. public class MyClassName : Singleton<MyClassName> {}
/// </summary>
public class MySingleton<T> : MyMonoBehaviour where T : MySingleton<T>
{
    // Check to see if we're about to be destroyed.
    private static readonly object m_Lock = new object();
    public static T m_Instance;

    public virtual void Init() { }

    public static T SetInstance()
    {

        lock (m_Lock)
        {
            if (m_Instance != null) return m_Instance;

            // Search for existing instance.
            m_Instance = (T)FindObjectOfType(typeof(T));

            // Create new instance if one doesn't already exist.
            if (m_Instance == null)
            {
                // Need to create a new GameObject to attach the singleton to.
                var singletonObject = new GameObject();
                m_Instance = singletonObject.AddComponent<T>();
                singletonObject.name = typeof(T).ToString() + " (Singleton)";

                // Make instance persistent.
                DontDestroyOnLoad(singletonObject);
            }

            m_Instance.Init(); // (Have some modify)

            return m_Instance;
        }
    }

    /// <summary>
    /// Access singleton instance through this propriety.
    /// </summary>
    public static T Instance
    {
        get
        {

            lock (m_Lock)
            {
                if (m_Instance == null)
                {
                    // Search for existing instance.
                    m_Instance = (T)FindObjectOfType(typeof(T));

                    // Create new instance if one doesn't already exist.
                    if (m_Instance == null)
                    {
                        // Need to create a new GameObject to attach the singleton to.
                        var singletonObject = new GameObject();
                        m_Instance = singletonObject.AddComponent<T>();
                        singletonObject.name = typeof(T).ToString() + " (Singleton)";

                        // Make instance persistent.
                        DontDestroyOnLoad(singletonObject);
                    }

                    m_Instance.Init(); // (Have some modify)
                }

                return m_Instance;
            }
        }
    }




}
