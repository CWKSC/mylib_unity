using UnityEngine;
using UnityEngine.UI;

public class CanvasComponents : MonoBehaviour
{
    public RectTransform rectTransform;
    public Canvas canvas;
    public CanvasScaler canvasScaler;
    public GraphicRaycaster graphicRaycaster;

    public void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
        canvas = GetComponent<Canvas>();
        canvasScaler = GetComponent<CanvasScaler>();
        graphicRaycaster = GetComponent<GraphicRaycaster>();
    }

}
