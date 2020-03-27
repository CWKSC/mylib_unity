using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParentOnRoot<T> : MyMonoBehaviour
{
    private T parent;

    public T Parent
    {
        get
        {
            if (parent == null) parent = transform.root.GetComponent<T>();
            return parent;
        }
    }

}
