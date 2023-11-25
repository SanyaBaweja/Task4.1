﻿using System;
using SplashKitSDK;

namespace Task4._1
{
	public class MyRectangle:Shape
	{
        private int _width;
        private int _height;
        public MyRectangle():this(Color.Green, 0, 0, 100, 100)
		{
            
        }
        public MyRectangle(Color clr, float x, float y, int width, int height):base(clr)
        {
            
            Width = width;
            Height = height;
        }
        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }

        }
        public override void Draw()
        {
            if (Selected == true)
            {
                Outline();
            }
            SplashKit.FillRectangle(Color, X, Y, _width, _height);

        }
        public override void Outline()
        {
            SplashKit.FillRectangle(Color.Black, X - 2, Y - 2, _width + 4, _height + 4);
        }

        public override bool IsAt(Point2D pt)
        {
            
                if (pt.X >= X && pt.X < (X + _width) && pt.Y >= Y && pt.Y <= (Y + _height))
            {

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

