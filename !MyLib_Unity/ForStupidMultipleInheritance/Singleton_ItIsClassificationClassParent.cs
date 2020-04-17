using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton_ItIsClassificationClassParent<T> : MyMonoBehaviour where T : MonoBehaviour
{
    #region Singleton Part

    // Check to see if we're about to be destroyed.
    private static bool m_ShuttingDown = false;
    private static object m_Lock = new object();
    private static T m_Instance;

    /// <summary>
    /// Access singleton instance through this propriety.
    /// </summary>
    public static T Instance
    {
        get
        {
            if (m_ShuttingDown)
            {
                Debug.LogWarning("[Singleton] Instance '" + typeof(T) +
                    "' already destroyed. Returning null.");
                return null;
            }

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
                }

                return m_Instance;
            }
        }
    }

    private void OnApplicationQuit()
    {
        m_ShuttingDown = true;
    }

    private void OnDestroy()
    {
        m_ShuttingDown = true;
    }

    #endregion

    #region ItIsClassificationClassParent Part

    public List<ItIsClassificationClassOf<T>> childsClass = new List<ItIsClassificationClassOf<T>>();

    /// <summary>
    /// It should run in end of Awake() of Attached Class
    /// </summary>
    public void Awake()
    {
        T parent = GetComponent<T>();
        for (int i = 0; i < childsClass.Count; i++)
        {
            childsClass[i].Initialization(parent);
            childsClass[i].Initialization();
        }
    }

    public void Start()
    {
        for (int i = 0; i < childsClass.Count; i++)
        {
            childsClass[i].Start();
        }
    }

    public void Update()
    {
        for (int i = 0; i < childsClass.Count; i++)
        {
            childsClass[i].Update();
        }
    }

    #endregion
}
