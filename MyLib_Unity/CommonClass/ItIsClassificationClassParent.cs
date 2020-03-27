using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItIsClassificationClassParent<T> : MyMonoBehaviour
{
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
}
