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

namespace ProyectoProgra
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BnAgregar_Click(object sender, RoutedEventArgs e)
        {
            switch (Consolas.SelectedIndex)
            {
                case 0:
                    Parametros.Children.Add(new ParNin64());
                    break;
                case 1:
                    Parametros.Children.Add(new ParGamecube());
                    break;
                case 2:
                    Parametros.Children.Add(new ParPlay2());
                    break;
                case 3:
                    Parametros.Children.Add(new ParXbox ());
                    break;
                case 4:
                    Parametros.Children.Add(new ParWii());
                    break;
                case 5:
                    Parametros.Children.Add(new ParPlay2());
                    break;
            }
        }
    }
}
