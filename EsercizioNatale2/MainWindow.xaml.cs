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

namespace EsercizioNatale2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double num1 = double.Parse(txt_num1.Text);
                double num2 = double.Parse(txt_num2.Text);
                if (cbx_scelta.SelectedIndex == 0)
                {
                    double somma = num1 + num2;
                    txt_ris.Text = somma.ToString();

                }
                else if (cbx_scelta.SelectedIndex == 1)
                {
                    double sottra = num1 - num2;
                    txt_ris.Text = sottra.ToString();
                }
                else if (cbx_scelta.SelectedIndex == 2)
                {
                    double molt = num1 * num2;
                    txt_ris.Text = molt.ToString();

                }
                else if (cbx_scelta.SelectedIndex == 3)
                {
                    if (num2 == 0)
                    {
                        MessageBox.Show("non puoi mettere 0", "Attenzione", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                    else
                    {
                        double div = num1 / num2;
                        txt_ris.Text = div.ToString();
                    }
                }
                string ris = txt_ris.Text;
                StreamWriter sr = new StreamWriter("Vecchie Operazioni.txt", false, Encoding.UTF8);
                sr.WriteLine(ris);
                sr.Flush();
                sr.Close();
            }catch
            {
                MessageBox.Show("Non puoi inserire delle lettere", "Errore", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
