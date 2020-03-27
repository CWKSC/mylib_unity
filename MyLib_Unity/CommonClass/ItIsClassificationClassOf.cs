using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ItIsClassificationClassOf<T>
{
    [HideInInspector]
    public T parentClass;

    public virtual void Initialization()
    {

    }

    public virtual void Initialization(T parentClass)
    {
        this.parentClass = parentClass;
    }

    public virtual void Start() { }

    public virtual void Update() { }



}
