using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItIsParent<T> : MonoBehaviour
{
    public List<ParentOnRoot<T>> childComponents = new List<ParentOnRoot<T>>();

    public void Awake()
    {
        ParentOnRoot<T>[] allChildren = GetComponentsInChildren<ParentOnRoot<T>>();
        childComponents.AddRange(allChildren);
    }

}
