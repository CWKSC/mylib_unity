using System;
using System.Collections.Generic;
using System.Text;

namespace MyLib_Csharp_Alpha.CommonClass
{
    public partial class MyMath
    {

        public const double TwoPI = 2 * Math.PI;
        public const double PIOver2 = Math.PI / 2;
        public const double PIOver4 = Math.PI / 4;
        public const double PIOver6 = Math.PI / 6;
        public const double PIOver8 = Math.PI / 8;
        public const double PIOver16 = Math.PI / 16;
        public const double PIOver32 = Math.PI / 32;
        public const double PIOver64 = Math.PI / 64;
        public const double ThreePIOverTwo = 3 * Math.PI / 2;


        // Convert Angle //

        public const double DegToRad = Math.PI / 180d;
        public const double DegToPI = 1 / 180d;
        public const double DegToGrad = 10d / 9d;
        public const double DegToTurn = 1d / 360d;

        public const double RadToDeg = 180d / Math.PI;
        public const double RadToPI = 1d / Math.PI;
        public const double RadToGrad = 200d / Math.PI;
        public const double RadToTurn = 1d / (2d * Math.PI);

        public const double PIToDeg = 180d;
        public const double PIToRad = Math.PI;
        public const double PIToGrad = 200d;
        public const double PIToTurn = 1d / 2d;

        public const double GradToDeg = 9d / 10d;
        public const double GradToRad = Math.PI / 200d;
        public const double GradToPI = 1d / 200d;
        public const double GradToTurn = 1d / 400d;

        public const double TurnToDeg = 360d;
        public const double TurnToRad = 2d * Math.PI;
        public const double TurnToPI = 2d;
        public const double TurnToGrad = 400d;

        public const double RightAngleDeg = TurnToDeg / 4d;
        public const double RightAngleRad = TurnToRad / 4d;
        public const double RightAnglePI = TurnToPI / 4d;
        public const double RightAngleGrad = TurnToGrad / 4d;
        public const double RightAngleTurn = 1d / 4d;

        public const double HalfTurnDeg = TurnToDeg / 2d;
        public const double HalfTurnRad = TurnToRad / 2d;
        public const double HalgTurnPI = TurnToPI / 2d;
        public const double HalfTurngGrad = TurnToGrad / 2d;
        public const double HalfTurn = 1d / 2d;


        // Square of root //
        
        public const float squareRoot2_float = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157f;
        public const float squareRoot3_float = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154f;
        public const float squareRoot5_float = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227f;
        public const float squareRoot6_float = 2.44948974278317809819728407470589139196594748065667f;
        public const float squareRoot7_float = 2.64575131106459059050161575363926042571025918308245f;
        public const float squareRoot8_float = 2.82842712474619009760337744841939615713934375075389f;
        public const float squareRoot10_float = 3.16227766016837933199889354443271853371955513932521f;

        public const double squareRoot2_double = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157;
        public const double squareRoot3_double = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154;
        public const double squareRoot5_double = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227;
        public const double squareRoot6_double = 2.44948974278317809819728407470589139196594748065667;
        public const double squareRoot7_double = 2.64575131106459059050161575363926042571025918308245;
        public const double squareRoot8_double = 2.82842712474619009760337744841939615713934375075389;
        public const double squareRoot10_double = 3.16227766016837933199889354443271853371955513932521;

        public const decimal squareRoot2_decimal = 1.41421356237309504880168872420969807856967187537694807317667973799073247846210703885038753432764157M;
        public const decimal squareRoot3_decimal = 1.7320508075688772935274463415058723669428052538103806280558069794519330169088000370811461867572485756756261414154M;
        public const decimal squareRoot5_decimal = 2.23606797749978969640917366873127623544061835961152572427089724541052092563780489941441440837878227M;
        public const decimal squareRoot6_decimal = 2.44948974278317809819728407470589139196594748065667M;
        public const decimal squareRoot7_decimal = 2.64575131106459059050161575363926042571025918308245M;
        public const decimal squareRoot8_decimal = 2.82842712474619009760337744841939615713934375075389M;
        public const decimal squareRoot10_decimal = 3.16227766016837933199889354443271853371955513932521M;

        public const int squareRootIntMax_int = 46340;
        public const float squareRootIntMax_float = 46340.950001051984145306050777435302734375f;
        public const double squareRootIntMax_double = 46340.950001051984145306050777435302734375;
        public const decimal squareRootIntMax_decimal = 46340.950001051984145306050777435302734375M;


    }
}
