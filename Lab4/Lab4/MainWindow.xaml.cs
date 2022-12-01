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
            DIV, 
            EXP,
            SQRT, 
            SIN, 
            COS
        }

        Operations operation;
        Operations prevOperation;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnPlus1_Click(object sender, RoutedEventArgs e)
        {
            if (operation != Operations.NONE)
            {
                calc();
                textBox.Text = a.ToString();
                operation = Operations.SUM;
                b = 0;
            } else
            {
                operation = Operations.SUM;
                b = 0;
            }
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            if (operation != Operations.NONE)
            {
                calc();
                textBox.Text = a.ToString();
                operation = Operations.SUBST;
                b = 0;
            }
            else
            {
                operation = Operations.SUBST;
                b = 0;
            }
        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            if (operation != Operations.NONE)
            {
                calc();
                textBox.Text = a.ToString();
                operation = Operations.DIV;
                b = 0;
            }
            else
            {
                operation = Operations.DIV;
                b = 0;
            }
        }

        private void btnExp_Click(object sender, RoutedEventArgs e)
        {
            if (operation != Operations.NONE)
            {
                calc();
                textBox.Text = a.ToString();
                operation = Operations.EXP;
                b = 0;
            }
            else
            {
                operation = Operations.EXP;
                b = 0;
            }
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (operation != Operations.NONE)
            {
                calc();
                textBox.Text = a.ToString();
                operation = Operations.SQRT;
                b = 0;
            }
            else
            {
                operation = Operations.SQRT;
                b = 0;
            }
        }

        private void btnSin_Click(object sender, RoutedEventArgs e)
        {
            if (operation != Operations.NONE)
            {
                calc();
                textBox.Text = a.ToString();
                operation = Operations.SIN;
                b = 0;
            }
            else
            {
                operation = Operations.SIN;
                b = 0;
            }
        }

        private void btnCos_Click(object sender, RoutedEventArgs e)
        {
            if (operation != Operations.NONE)
            {
                calc();
                textBox.Text = a.ToString();
                operation = Operations.COS;
                b = 0;
            }
            else
            {
                operation = Operations.COS;
                b = 0;
            }
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            if (operation != Operations.NONE)
            {
                calc();
                textBox.Text = a.ToString();
                operation = Operations.MULT;
                b = 0;
            }
            else
            {
                operation = Operations.MULT;
                b = 0;
            }
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

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            a = 0;
            b = 0;
            operation = Operations.NONE;
            textBox.Text = b.ToString();
        }

        private void calc()
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
                case Operations.EXP:
                    a = Convert.ToInt64(Math.Pow(a, b));
                    break;
                case Operations.SQRT:
                    a = Convert.ToInt64(Math.Sqrt(a));
                    break;
                case Operations.SIN:
                    a = Convert.ToInt64(Math.Sin(a));
                    break;
                case Operations.COS:
                    a = Convert.ToInt64(Math.Cos(a));
                    break;
            }
        }

        private void btnCalc_Click_1(object sender, RoutedEventArgs e)
        {
            //if (prevOperation == operation) 
            calc();
            //prevOperation = operation;
            textBox.Text = a.ToString();
        }


    }
}
