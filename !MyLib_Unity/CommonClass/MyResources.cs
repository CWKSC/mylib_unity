using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class MyResources
{

    // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs

    /// <summary>
    /// Resources.Load 並檢查是否null
    /// </summary>
    public static T ResourcesLoadCheckNull<T>(string name) where T : UnityEngine.Object
    {
        T loadGo = Resources.Load<T>(name);

        if (loadGo == null)
        {
            Debug.LogError("Resources.Load [ " + name + " ] is Null !!");
            return default(T);
        }

        return loadGo;
    }

    /// <summary>
    /// Resources.Load Sprite
    /// </summary>
    public static Sprite ResourcesLoadSprite(string name)
    {
        return ResourcesLoadCheckNull<Sprite>("Sprites/" + name);
    }

    /// <summary>
    /// 讀TXT檔
    /// </summary>
    public static void LoadFile(string path)
    {
        string strTemp;
        TextReader reader = null;

        TextAsset data = Resources.Load(path, typeof(TextAsset)) as TextAsset;

        if (data != null)
            reader = new StringReader(data.text);

        if (reader != null)
        {
            while ((strTemp = reader.ReadLine()) != null)
            {
                Debug.Log(strTemp);
            }

            reader.Close();
        }
    }
}
