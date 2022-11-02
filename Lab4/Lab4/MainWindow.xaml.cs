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

namespace Lab4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        long a, b;

        enum Operations
        {
            NONE,
            SUM,
            SUBST,
            MULT,
            DIV
        }

        Operations operation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlus1_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.SUM;
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.SUBST;
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.DIV;
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            operation = Operations.MULT;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (operation == Operations.NONE)
            {
                a = a * 10 + int.Parse(((Button)sender).Content.ToString());
                textBox.Text = a.ToString();
            }
            else
            {
                b = b * 10 + int.Parse(((Button)sender).Content.ToString());
                textBox.Text = b.ToString();
            }
        }

        private void btnCalc_Click_1(object sender, RoutedEventArgs e)
        {
            switch (operation)
            {
                case Operations.SUM:
                    a = a + b;
                    break;
                case Operations.SUBST:
                    a = a - b;
                    break;
                case Operations.MULT:
                    a = a * b;
                    break;
                case Operations.DIV:
                    a = a / b;
                    break;
            }
            b = 0;
            textBox.Text = a.ToString();
        }


    }
}
