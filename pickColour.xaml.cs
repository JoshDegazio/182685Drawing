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
using System.Windows.Shapes;

namespace _182685Drawing
{
    /// <summary>
    /// Interaction logic for pickColor.xaml
    /// </summary>
    public partial class pickColour : Window
    {
        public pickColour()
        {
            InitializeComponent();

            for (int r = 0; r < 256; r += 33)
            {
                Button b = new Button();
                b.Background = new SolidColorBrush(Color.FromRgb((byte)r, 0, 0));
                b.Content = " ";
                b.Click += btnPickColour_Click;
                stackPanel.Children.Add(b);
            }

            for (int r = 0; r < 256; r += 33)
            {
                Button b = new Button();
                b.Background = new SolidColorBrush(Color.FromRgb(0, (byte)r, 0));
                b.Content = " ";
                b.Click += btnPickColour_Click;
                stackPanel.Children.Add(b);
            }

            for (int r = 0; r < 256; r += 33)
            {
                Button b = new Button();
                b.Background = new SolidColorBrush(Color.FromRgb(0, 0, (byte)r));
                b.Content = " ";
                b.Click += btnPickColour_Click;
                stackPanel.Children.Add(b);
            }
        }

        private void btnPickColour_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.b = ((Button)sender).Background;
            DialogResult = true;
        }
    }
}