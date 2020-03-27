using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewComponents : MonoBehaviour
{
    public RectTransform rectTransform;
    public CanvasRenderer canvasRenderer;
    public Image image;
    public ScrollRect scrollRect;

    void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvasRenderer = GetComponent<CanvasRenderer>();
        image = GetComponent<Image>();
        scrollRect = GetComponent<ScrollRect>();
    }
}
