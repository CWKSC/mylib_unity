using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class MySystem
{


    /// <summary>
    /// 取得系統資訊
    /// </summary>
    public static string GetSystemInfo()
    {
        // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
        StringBuilder sb = new StringBuilder();

        sb.Append("CPU 型號：" + SystemInfo.processorType + "\n");
        sb.Append("cores 核心數：" + SystemInfo.processorCount + "\n");
        sb.Append("RAM 內存(MB)：" + SystemInfo.systemMemorySize + "\n");
        sb.Append("顯卡型號：" + SystemInfo.graphicsDeviceName + "\n");
        sb.Append("畫面寬：" + Screen.width + "\n");
        sb.Append("畫面高：" + Screen.height + "\n");
        sb.Append("畫面更新率：" + Screen.currentResolution.refreshRate + "\n");
        sb.Append("VRAM 顯存：：" + SystemInfo.graphicsMemorySize + "\n");

        return sb.ToString();
    }

}
