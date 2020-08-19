using MyLib_Csharp_Alpha.CommonClass;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyTime 
{

    // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs

    /// <summary>
    /// 算時間差距，完成時間(傳入時間) - 現在時間
    /// </summary>
    /// <returns>如果 "現在時間" 已經超過 "完成時間" 回傳 TimeSpan.Zero</returns>
    public static TimeSpan TimeGap(DateTime timeComplete)
    {
        if (DateTime.Compare(DateTime.Now, timeComplete) > 0)
            return TimeSpan.Zero;
        else
            return timeComplete.Subtract(DateTime.Now);
    }

    /// <summary>
    /// 透過時間設定 Text、Slider
    /// </summary>
    /// <param name="_slider">UI Slider</param>
    /// <param name="_text">UI Text</param>
    /// <param name="completeMsg">完成時顯示文字</param>
    /// <param name="completeTime">完成時間</param>
    /// <param name="totalTime">總共時間(秒)</param>
    /// <returns>如果 "現在時間" 已經超過 "完成時間" 回傳 TimeSpan.Zero</returns>
    public static TimeSpan SetTimeUI(Slider _slider, Text _text, string completeMsg, DateTime completeTime, float totalTime)
    {
        //算剩餘時間
        TimeSpan lastTime = TimeGap(completeTime);

        //時間到
        if (lastTime == TimeSpan.Zero)
        {
            if (_text != null)
                _text.text = completeMsg;

            if (_slider != null)
                _slider.value = 1;
        }
        else
        {
            if (_text != null)
                _text.text = MyFormat.TimeSpanToString(lastTime);

            if (_slider != null)
                _slider.value = 1 - ((float)lastTime.TotalSeconds / (totalTime * 60));
        }

        return lastTime;
    }
}
