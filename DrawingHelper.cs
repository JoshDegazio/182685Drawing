using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace _182685Drawing
{
    class DrawingHelper
    {
        Canvas c  = new Canvas();
        Rectangle r = new Rectangle();
        Ellipse e = new Ellipse();

        public DrawingHelper(Canvas C, double X, double Y, double W, double H, Brush colour, string Shape)
        {

            c = C;
            if (Shape == "Ellipse")
            {
                CreateEllipse(X, Y, W, H, colour);
            }
            else if (Shape == "Rectangle")
            {
                CreateRectangle(X, Y, W, H, colour);
            }
        }

        private void CreateEllipse(double X, double Y, double W, double H, Brush colour)
        {
            Ellipse e = new Ellipse();

            e.Height = H;
            e.Width = W;
            e.Fill = colour;

            Canvas.SetLeft(e, X);
            Canvas.SetTop(e, Y);

            c.Children.Add(e);
        }

        private void CreateRectangle(double X, double Y, double W, double H, Brush colour)
        {
            Rectangle r = new Rectangle();

            r.Height = H;
            r.Width = W;
            r.Fill = colour;

            Canvas.SetLeft(r, X);
            Canvas.SetTop(r, Y);

            c.Children.Add(r);
        }
    }
}
