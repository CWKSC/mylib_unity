using MyLib_Csharp_Alpha.DataStructure;
using MyLib_Csharp_Alpha.MyType;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public static partial class MyMath
    {



        #region Normalize

        #region NormalizeList
        /// <summary> return new List </summary>
        public static List<double> NormalizeList(List<double> list) => UnitVector2ToList(ListToUnitVector2(list));
        #endregion

        #region Normalize angle

        #region Normalize angle [0, fullTurn)
        /// <summary> [0, 360) </summary>
        public static double NormalizeDegrees_0_360(double degrees)
        {
            while (degrees >= TurnToDeg) degrees -= TurnToDeg;
            while (degrees < 0) degrees += TurnToDeg;
            return degrees;
        }
        /// <summary> [0, TwoPI) </summary>
        public static double NormalizeRadians_0_TwoPI(double radians)
        {
            while (radians >= TurnToRad) radians -= TurnToRad;
            while (radians < 0) radians += TurnToRad;
            return radians;
        }
        /// <summary> [0, 400) </summary>
        public static double NormalizeGradians_0_400(double gradians)
        {
            while (gradians >= TurnToGrad) gradians -= TurnToGrad;
            while (gradians < 0) gradians += TurnToGrad;
            return gradians;
        }
        /// <summary> [0, 1) </summary>
        public static double NormalizeTurn_0_1(double turns)
        {
            while (turns >= 0) turns -= 1;
            while (turns < 0) turns += 1;
            return turns;
        }
        /// <summary> [0, fullTurn) , return new Angle</summary> 
        public static Angle NormalizeAngle_0_fullTurn(Angle angle) => new Angle(angle).Normalize();
        #endregion

        #region Normalize angle [-halfTurn, halfTurn)
        /// <summary> [-180, 180) </summary>
        public static double NormalizeDegrees_neg180_180(double degrees)
        {
            while (degrees >= HalfTurnDeg) degrees -= TurnToDeg;
            while( degrees < -HalfTurnDeg) degrees += TurnToDeg;
            return degrees;
        }
        #endregion

        #endregion

        #endregion



    }
}
