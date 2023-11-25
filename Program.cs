using System;
using SplashKitSDK;
namespace Task4._1
{
    public class Program
    {
        private enum ShapeKind
        {
            Rectangle, Circle, Line
        }

        public static void Main()
        {
            Window window = new Window("Shape Drawer", 800, 600);

            Drawing dr = new Drawing();
            ShapeKind kindToAdd = ShapeKind.Circle;
            do
            {
                SplashKit.ProcessEvents();
                SplashKit.ClearScreen();
                
                if (SplashKit.MouseClicked(MouseButton.LeftButton))
                {
                    Shape newShape;
                    if (kindToAdd == ShapeKind.Circle)
                    {
                        newShape = new MyCircle();
                    }
                    else if (kindToAdd == ShapeKind.Rectangle)
                    {
                        newShape = new MyRectangle();
                    }
                    else 
                    {
                        newShape = new MyLine();
                    }

                    newShape.X = SplashKit.MouseX();

                    newShape.Y = SplashKit.MouseY();

                    dr.AddShape(newShape);
                }
                
                if (SplashKit.KeyTyped(KeyCode.RKey))
                {
                    kindToAdd = ShapeKind.Rectangle;
                }

                if (SplashKit.KeyTyped(KeyCode.CKey))
                {
                    kindToAdd = ShapeKind.Circle;
                }
                if (SplashKit.KeyTyped(KeyCode.LKey))
                {
                    kindToAdd = ShapeKind.Line;
                }
                if (SplashKit.MouseClicked(MouseButton.RightButton))
                {
          
                    dr.SelectShapesAt(SplashKit.MousePosition());
                }

                if (SplashKit.KeyTyped(KeyCode.SpaceKey))
                {

                    dr.Background1 = SplashKit.RandomRGBColor(255);
                }

                if (SplashKit.KeyTyped(KeyCode.DeleteKey))
                {
                    
                    foreach (Shape s in dr.Selectedshapes)
                    {
                       

                        dr.DeleteShape(s);
                    }
                }

                if (SplashKit.KeyTyped(KeyCode.BackspaceKey))
                {
                    foreach (Shape s in dr.Selectedshapes)
                    {
                        dr.DeleteShape(s);
                    }
                }

                
                dr.Draw();
                SplashKit.RefreshScreen();
            } while (!window.CloseRequested);
        }
    }

}





