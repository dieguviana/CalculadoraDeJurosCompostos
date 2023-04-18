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
using CalculadoraDeJurosCompostos.Properties;

namespace CalculadoraDeJurosCompostos
{
   
    

    /// <summary>
    /// Lógica interna para CalcularJuros.xaml
    /// </summary>
    public partial class CalcularJuros : Window
    {
        public CalcularJuros()
        {
        InitializeComponent();
        }

        private void BtMontante_Click(object sender, RoutedEventArgs e)
        {
            double valorCapital = Convert.ToDouble(tbCapital.Text);
            double valorTaxa = Convert.ToDouble(tbTaxa.Text) / 100; // Divide por 100 para obter a taxa em decimal
            double valorTempo = Convert.ToDouble(tbTempo.Text);

            double valorMontante = CalcularMontante(valorCapital, valorTaxa, valorTempo);

            tbMontante.Text = Convert.ToString(valorMontante);

            double CalcularMontante(double valorInicial, double taxa, double tempo)
            {
                return valorInicial * Math.Pow((1 + taxa), tempo);
            }
        }
    }
}
