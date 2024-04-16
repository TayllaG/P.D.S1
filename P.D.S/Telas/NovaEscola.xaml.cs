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

namespace P.D.S.Telas
{
    /// <summary>
    /// Lógica interna para NovaEscola.xaml
    /// </summary>
    public partial class NovaEscola : Window
    {
        public NovaEscola()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuEscola mnescola = new MenuEscola();
            mnescola.Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MenuCurso mncurso = new MenuCurso();
            mncurso.Show();
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MenuTurma mnturma = new MenuTurma();
            mnturma.Show();
            this.Close();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

            this.Close();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            tx_nomefantasia.Text = "";
            tx_razaosocial.Text = "";
            tx_cnpj.Text = "";
            tx_endereco.Text = "";
            tx_cidade.Text = "";
            tx_estado.Text = "";
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {

        }
    }
}
