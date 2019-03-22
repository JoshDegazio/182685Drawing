using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.IO;

namespace _182685Drawing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Global Scope Variables
        public static Brush b;

        // private string shapeToSave;
        private string input;
        private string[] valuesStr;
        private int[] valuesInt= new int[4];
        private int xOffset;
        private int yOffset;
        private int width;
        private int height;

        private static string Shape;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetColour_Click(object sender, RoutedEventArgs e)
        {
            pickColour p = new pickColour();
            p.ShowDialog();
        }

        private void BtnDraw_Click(object sender, RoutedEventArgs e)
        {
            SetValues();

            //shapeToSave = canvas + "," + xOffset + "," + yOffset + "," + width + "," + height + "," + b + "," + Shape;
            DrawingHelper DH = new DrawingHelper(canvas, xOffset, yOffset, width, height, b, Shape);

            //using (StreamWriter shapeWriter = new StreamWriter("shapes.txt"))
            //{
            //    try
            //    {
            //        //Writes a single line with the text given
            //        shapeWriter.WriteLine(shapeToSave);
            //        //Makes sure no data is left in the stream
            //        shapeWriter.Flush();
            //        //Ends stream
            //        shapeWriter.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            // }
        }

        private void SetValues()
        {
            input = txtInput.Text;
            valuesStr = input.Split(',');

            int.TryParse(valuesStr[0], out valuesInt[0]);
            int.TryParse(valuesStr[1], out valuesInt[1]);
            int.TryParse(valuesStr[2], out valuesInt[2]);
            int.TryParse(valuesStr[3], out valuesInt[3]);

            xOffset = valuesInt[0];
            yOffset = valuesInt[1];
            width = valuesInt[2];
            height = valuesInt[3];
        }

        private void RbEli_Checked(object sender, RoutedEventArgs e)
        {
            Shape = "Ellipse";
        }

        private void RbRec_Checked(object sender, RoutedEventArgs e)
        {
            Shape = "Rectangle";
        }
    }
}
