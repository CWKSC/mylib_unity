using MyLib_Csharp.DataStructure;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp.CommonClass
{
    static class MyConvert
    {

        #region Vector2 convert
        public static double ToDegrees(this Vector2 vector2) => MyMath.CartesianToPolar_Degrees(vector2);
        public static double ToRadians(this Vector2 vector2) => MyMath.CartesianToPolar_Radians(vector2);
        public static double ToPI(this Vector2 vector2) => MyMath.CartesianToPolar_PI(vector2);
        public static double ToGradians(this Vector2 vector2) => MyMath.CartesianToPolar_Gradians(vector2);
        public static double ToTurns(this Vector2 vector2) => MyMath.CartesianToPolar_Turns(vector2);
        public static Vector2 ToUnitVector2(this Vector2 vector2) => Vector2.Normalize(vector2);
        /// <summary> return new List </summary>
        public static List<double> ToList(this Vector2 vector2) => new List<double>() { vector2.X, vector2.Y };
        /// <summary> return new List </summary>
        public static List<double> ToUnitList(this Vector2 vector2) => MyMath.NormalizeList(ToList(vector2));
        /// <summary> return new Angle </summary>
        public static Angle ToAngle(this Vector2 vector2) => new Angle(vector2);
        #endregion

        public static T GetDefaultValue<T>() => default;

        public static bool StringToBool(string value)
        {
            // Reference : https://github.com/k79k06k02k/Utility/blob/master/Scripts/Utility.cs
            if (value == "T")
                return true;
            else if (value == "F")
                return false;
            else
            {
                Console.WriteLine(string.Format("Unable to convert value:[{0}]", value));
                return false;
            }
        }

    }
}
