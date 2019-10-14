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
    /// Lógica de interacción para ParNin64.xaml
    /// </summary>
    public partial class ParNin64 : UserControl
    {
        public ParNin64()
        {
            InitializeComponent();

        }


        private void BnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if(NombrePro.Text == "" || Uso.Text == "" || Valor.Text == "" || Descuento.Text == "" || Antigüedad.Text == "")
                Señal.Visibility = Visibility.Visible;

            else
                n64.Visibility = Visibility.Hidden;
        }

        private void BnCancelar_Click(object sender, RoutedEventArgs e)
        {
            n64.Visibility = Visibility.Hidden;
        }

        private void Descuento_TextChanged(object sender, TextChangedEventArgs e)
        {
            Señal.Visibility = Visibility.Hidden;
        }

        private void Uso_TextChanged(object sender, TextChangedEventArgs e)
        {
            Señal.Visibility = Visibility.Hidden;
        }

        private void Valor_TextChanged(object sender, TextChangedEventArgs e)
        {
            Señal.Visibility = Visibility.Hidden;
        }

        private void NombrePro_TextChanged(object sender, TextChangedEventArgs e)
        {
            Señal.Visibility = Visibility.Hidden;
        }

        private void Antigüedad_TextChanged(object sender, TextChangedEventArgs e)
        {
            Señal.Visibility = Visibility.Hidden;
        }
    }
}
