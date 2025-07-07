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

namespace Shapeland
{
    /// <summary>
    /// Interaction logic for Hexagon.xaml
    /// </summary>
    public partial class Hexagon : UserControl
    {
        public Hexagon()
        {
            InitializeComponent();
            SizeChanged += Hexagon_SizeChanged;
        }

        private void Hexagon_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double scaleX = e.NewSize.Width / 90.0;
            double scaleY = e.NewSize.Height / 90.0;
            UserControlScale.ScaleX = scaleX;
            UserControlScale.ScaleY = scaleY;
        }
    }
}
