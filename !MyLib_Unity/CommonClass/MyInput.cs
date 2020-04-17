using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInput
{

    public static void MouseXY(Action<float, float> action)
    {
        action(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
    }

    public static void WASD(Action w, Action a, Action s, Action d)
    {
        if (Input.GetKey(KeyCode.W)) w();
        if (Input.GetKey(KeyCode.A)) a();
        if (Input.GetKey(KeyCode.S)) s();
        if (Input.GetKey(KeyCode.D)) d();
    }


    public static void Space(Action space)
    {
        if (Input.GetKey(KeyCode.Space)) space();
    }


    public static void LeftShift(Action leftShift)
    {
        if (Input.GetKey(KeyCode.LeftShift)) leftShift();
    }


    #region Left Mouse 
    public static void LeftMouse(Action action)
    {
        if (Input.GetMouseButton(0)) { action(); }
    }
    public static void LeftMouseDown(Action action)
    {
        if (Input.GetMouseButtonDown(0)) { action(); }
    }
    public static void LeftMouseUp(Action action)
    {
        if (Input.GetMouseButtonUp(0)) { action(); }
    }
    #endregion

    #region Right Mouse
    public static void RightMouse(Action action)
    {
        if (Input.GetMouseButton(1)) { action(); }
    }
    public static void RightMouseDown(Action action)
    {
        if (Input.GetMouseButtonDown(1)) { action(); }
    }
    public static void RightMouseUp(Action action)
    {
        if (Input.GetMouseButtonUp(1)) { action(); }
    }
    #endregion

    #region Middle Mouse
    public static void MiddleMouse(Action action)
    {
        if (Input.GetMouseButton(2)) { action(); }
    }
    public static void MiddleMouseDown(Action action)
    {
        if (Input.GetMouseButtonDown(2)) { action(); }
    }
    public static void MiddleMouseUp(Action action)
    {
        if (Input.GetMouseButtonUp(2)) { action(); }
    }
    #endregion


}
