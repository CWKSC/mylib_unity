using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyVector
{

    #region A to B 

    public static Vector2 AtoB(Vector2 a, Vector2 b)
    {
        return b - a;
    }

    public static Vector3 AtoB(Vector3 a, Vector3 b)
    {
        return b - a;
    }

    #endregion

    #region Vector3 to Quaternion

    public static Quaternion Vector3ToQuaternion(Vector3 vector)
    {
        return Quaternion.LookRotation(vector);
    }

    public static Quaternion Vector3ToQuaternion_Safe(Vector3 vector)
    {
        if (vector == Vector3.zero)
        {
            return Quaternion.identity;
        }
        return Quaternion.LookRotation(vector);
    }

    public static Quaternion Vector3ToQuaternion_Safe(Vector3 vector, Quaternion expectionQuaternion)
    {
        if (vector == Vector3.zero)
        {
            return expectionQuaternion;
        }
        return Quaternion.LookRotation(vector);
    }

    #endregion

    #region string to Vector

    public static Vector2 StringToVector2(string value)
    {
        string[] str = value.Split(',');
        return new Vector2(float.Parse(str[0]), float.Parse(str[1]));
    }
    public static Vector3 StringToVector3(string value)
    {
        string[] str = value.Split(',');
        return new Vector3(float.Parse(str[0]), float.Parse(str[1]), float.Parse(str[2]));
    }

    #endregion

    #region Abs Vector
    /// <summary>
    /// Vector2 絕對值
    /// </summary>
    public static Vector2 Vector2Abs(Vector2 org)
    {
        return new Vector2(Mathf.Abs(org.x), Mathf.Abs(org.y));
    }
    /// <summary>
    /// Vector3 絕對值
    /// </summary>
    public static Vector3 Vector3Abs(Vector3 org)
    {
        return new Vector3(Mathf.Abs(org.x), Mathf.Abs(org.y), Mathf.Abs(org.z));
    }
    #endregion
}
