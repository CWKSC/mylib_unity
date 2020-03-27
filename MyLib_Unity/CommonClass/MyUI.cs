using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MyUI 
{
    public static void SetRectTransformWidthHeight(RectTransform rectTransform, float width, float height)
    {
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
        rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
    }

    public static Vector3 GetUIElementPositionAtMouse()
    {
        return Input.mousePosition - MyPosition.mousePositionOffset;
    }
    public static void SetUIElementPositionAtMouse(Transform UIelement)
    {
        UIelement.localPosition = Input.mousePosition - MyPosition.mousePositionOffset;
    }

    /// <summary>
    ///  判斷是否點到UI
    /// </summary>
    /// <returns>True:有  False:無</returns>
    public static bool IsPointerOverUIObject()
    {
        // Referencing this code for GraphicRaycaster https://gist.github.com/stramit/ead7ca1f432f3c0f181f
        // the ray cast appears to require only eventData.position.
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(eventDataCurrentPosition, results);

        return results.Count > 0;
    }
    public static bool IsPointerOverUIObject(Canvas canvas, Vector2 screenPosition)
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = screenPosition;

        GraphicRaycaster uiRaycaster = canvas.gameObject.GetComponent<GraphicRaycaster>();
        List<RaycastResult> results = new List<RaycastResult>();
        uiRaycaster.Raycast(eventDataCurrentPosition, results);

        return results.Count > 0;
    }

    /// <summary>
    /// UI 射線檢測
    /// </summary>
    public static List<RaycastResult> UIRaycast(Canvas canvas, Vector2 screenPosition)
    {
        PointerEventData eventDataCurrentPosition = new PointerEventData(EventSystem.current);
        eventDataCurrentPosition.position = screenPosition;

        GraphicRaycaster uiRaycaster = canvas.gameObject.GetComponent<GraphicRaycaster>();
        List<RaycastResult> results = new List<RaycastResult>();
        uiRaycaster.Raycast(eventDataCurrentPosition, results);

        return results;
    }
}
