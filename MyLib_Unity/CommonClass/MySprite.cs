using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MySprite 
{
    /// <summary> 
    /// 設定sprite sortingOrder
    /// </summary>
    public static void SetDepth(SpriteRenderer sprite, int depth)
    {
        if (sprite == null)
        {
            Debug.LogError("SpriteRenderer is Null!!");
            return;
        }

        sprite.sortingOrder = depth;
    }
}
