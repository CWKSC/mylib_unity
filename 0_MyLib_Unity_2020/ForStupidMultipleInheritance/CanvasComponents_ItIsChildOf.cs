using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasComponents_ItIsChildOf<T> : MonoBehaviour
{
    public RectTransform rectTransform;
    public Canvas canvas;
    public CanvasScaler canvasScaler;
    public GraphicRaycaster graphicRaycaster;

    public T parentClass;

    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponent<Canvas>();
        canvasScaler = GetComponent<CanvasScaler>();
        graphicRaycaster = GetComponent<GraphicRaycaster>();

        parentClass = transform.root.GetComponent<T>();
    }

}
