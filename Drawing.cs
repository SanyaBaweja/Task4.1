using System;
using SplashKitSDK;
using System.Collections.Generic;
namespace Task4._1

{
    public class Drawing
    {
        private readonly List<Shape> _shapes;
        private Color _background;
        public Drawing(Color bg)
        {
            _shapes = new List<Shape>();
            _background = bg;

        }
        public Drawing() : this(Color.White)
        {

        }
        public int ShapeCount
        {
            get
            {
                return _shapes.Count;
            }
        }
        public void AddShape(Shape s)
        {
            _shapes.Add(s);
        }
        public void Draw()
        {
            SplashKit.ClearScreen(Background1);
            foreach (Shape s in _shapes)
            {
                s.Draw();
            }

        }

        public void SelectShapesAt(Point2D pt)
        {
            foreach (Shape s in _shapes)
            {
                if (s.IsAt(pt))
                {
                    s.Selected = true;
                }
                else
                {
                    s.Selected = false;
                }
            }
        }
        public List<Shape> Selectedshapes
        {
            get
            {
                List<Shape> _result = new List<Shape>();


                foreach (Shape s in _shapes)
                {
                    if (s.Selected == true)
                    {
                        _result.Add(s);
                    }
                }
                return _result;
            }
        }
        public Color Background1
        {
            get
            {
                return _background;
            }
            set
            {
                _background = value;
            }
        }

        public void DeleteShape(Shape s)
        {
            _shapes.Remove(s);
        }
    }
}




