using System;
using System.Collections.Generic;
using System.IO;
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

namespace lab_10_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string first, second;
        private int k, l, m, n;
        public MainWindow()
        {
            InitializeComponent();
            first = Environment.CurrentDirectory + "\\first.txt";
            second = Environment.CurrentDirectory + "\\second.txt";
            FileInfo firstFile=new FileInfo(first);
            FileInfo secondFile=new FileInfo(second);
            if (firstFile.Exists) firstFile.Delete();
            else firstFile.Create();
            if (secondFile.Exists) secondFile.Delete();
            else secondFile.Create();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            k = int.Parse(K.Text);
            l=int.Parse(L.Text);
            m=int.Parse(M.Text);
            n=int.Parse(N.Text);

        }
    }
}
