using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyType
{
    public static T GetDefaultValue<T>()
    {
        return default(T);
    }

    public static bool StringToBool(string value)
    {
        if (value == "T")
            return true;
        else if (value == "F")
            return false;
        else
        {
            Debug.LogError(string.Format("Unable to convert value:[{0}]", value));
            return false;
        }
    }
}
