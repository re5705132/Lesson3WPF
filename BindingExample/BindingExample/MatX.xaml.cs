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

namespace BindingExample
{
    /// <summary>
    /// Interaction logic for MatX.xaml
    /// </summary>
    public partial class MatX1 : MatX
    {
        public MatX1()
        {
            var a=base.Star;
        }
    }
    public partial class MatX : Window
    {
       public Point Star = new Point(3, 3);
        public MatX()
        {
            InitializeComponent();
            DataContext = Star;
        }

        private void Grid_Click(object sender, RoutedEventArgs e)
        {
            Button b=e.OriginalSource as Button;
            int x =int.Parse( b.GetValue(Grid.RowProperty).ToString());
            int y =int.Parse( b.GetValue(Grid.ColumnProperty).ToString());
            Star = new Point(x, y);
            DataContext = new Point(x,y);
            
        }
    }
}
