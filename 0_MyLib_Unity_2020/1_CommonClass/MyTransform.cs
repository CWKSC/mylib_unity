using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTransform 
{

    public static IEnumerator SmoothMove(Transform transform, Vector3 oldPosition, Quaternion oldQuaternion, Vector3 newPosition, Quaternion newQuaternion, float time = 1.0f)
    {
        for (float timeCount = 0; timeCount <= time; timeCount += Time.deltaTime)
        {
            transform.position = Vector3.Lerp(oldPosition, newPosition, timeCount / time);
            transform.rotation = Quaternion.Lerp(oldQuaternion, newQuaternion, timeCount / time);
            yield return null;
        }
        transform.position = newPosition;
        transform.rotation = newQuaternion;
        yield return null;
    }

    // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs

    /// <summary>
    /// 將世界座標轉為Canvas座標
    /// </summary>
    /// <param name="canvas">目標Canvas</param>
    /// <param name="world_position">世界座標位置</param>
    /// <param name="camera">目標camera</param>
    /// <returns></returns>
    public static Vector2 WorldToCanvas(Canvas canvas, Vector3 world_position, Camera camera = null)
    {
        if (camera == null)
        {
            camera = Camera.main;
        }

        var viewport_position = camera.WorldToViewportPoint(world_position);
        var canvas_rect = canvas.GetComponent<RectTransform>();

        return new Vector2((viewport_position.x * canvas_rect.sizeDelta.x) - (canvas_rect.sizeDelta.x * 0.5f),
                           (viewport_position.y * canvas_rect.sizeDelta.y) - (canvas_rect.sizeDelta.y * 0.5f));
    }

    /// <summary>
    /// Transform 重置Position、Rotation、Scale
    /// </summary>
    public static void ResetTransform(Transform trans)
    {
        trans.localRotation = Quaternion.identity;
        trans.localPosition = Vector3.zero;
        trans.localScale = Vector3.one;
    }

    /// <summary>
    /// RectTransform 重置 AnchoredPosition、Anchor、Pivot、Rotation、Scale
    /// </summary>
    public static void ResetRectTransform(RectTransform rectTrans)
    {
        rectTrans.anchoredPosition = Vector3.zero;
        rectTrans.anchorMin = Vector2.one * 0.5f;
        rectTrans.anchorMax = Vector2.one * 0.5f;
        rectTrans.pivot = Vector2.one * 0.5f;
        rectTrans.localRotation = Quaternion.identity;
        rectTrans.localScale = Vector3.one;
    }

}
