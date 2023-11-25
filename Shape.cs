﻿using System;

using SplashKitSDK;

namespace Task4._1
{
    public abstract class Shape
    {
        protected Color _color;
        private float _x;
        private float _y;
        
        private bool _selected;

        public Shape(Color c)
        {
            _color = c;
            _x = (float)0;
            _y = (float)0;
            
        }
        public Shape():this(Color.Yellow)
        {

        }

        public abstract void Draw();
       
        public Color Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }

        public float X
        {
            get
            {
                return _x;
            }
            set
            {
                _x = value;
            }
        }
        public float Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }

        }
        
        public bool Selected
        {
            get
            {
                return _selected;
            }
            set
            {
                _selected = value;
            }
        }
        public abstract bool IsAt(Point2D pt);
        
        public abstract void Outline();
        
}
}



