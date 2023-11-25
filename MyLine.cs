using System;
using System.Numerics;
using SplashKitSDK;
namespace Task4._1
{
    public class MyLine : Shape
    {
        private float _endX;
        private float _endY;


        public MyLine() : this(Color.Orange, 0, 0, 200, 300)
        {

        }
        public MyLine(Color clr, float startX, float startY, float endX, float endY) : base(clr)
        {
            
            EndX = endX;
            EndY = endY;

        }

        public float EndX
        {
            get
            {
                return _endX;
            }
            set
            {
                _endX = value;
            }
        }

        public float EndY
        {
            get
            {
                return _endY;
            }
            set
            {
                _endY = value;
            }
        }

        public override void Draw()
        {
            if (Selected)
                Outline();
            SplashKit.DrawLine(Color, X, Y, EndX, EndY, SplashKit.OptionLineWidth(5));
            
        }
        public override void Outline()
        {

            
            SplashKit.FillCircle(Color.Black, X, Y, 4);
            SplashKit.FillCircle(Color.Black, EndX, EndY, 4);
            
        }
        public override bool IsAt(Point2D pt)
        {


            Line l = SplashKit.LineFrom(X, Y, EndX, EndY);
            

            return SplashKit.PointOnLine(pt, l, 10);
        }


    }
}










