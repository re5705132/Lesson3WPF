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

namespace BindingExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BPerson bp = new  BPerson();
            if(bp is AStudent)
                ((AStudent)bp).MyFun();
            var q = bp as AStudent;
            if(q!=null)
                ((AStudent)bp).MyFun();
            object o1 = new AStudent();
            o1.Equals(new AStudent());
            // AStudent a = new BPerson();
        }
    }
}
