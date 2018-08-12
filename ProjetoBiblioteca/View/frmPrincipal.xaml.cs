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

namespace ProjetoBiblioteca.View
{
    /// <summary>
    /// Interaction logic for frmPrincipal.xaml
    /// </summary>
    public partial class frmPrincipal : Window
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            

            
        }

        private void menCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarFuncionario form = new frmCadastrarFuncionario();
            form.ShowDialog();
        }

        private void menCadastrarCliente_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarCliente form = new frmCadastrarCliente();
            form.ShowDialog();
        }

        private void menCadastrarBiblioteca_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarBiblioteca form = new frmCadastrarBiblioteca();
            form.ShowDialog();
        }

        private void menCadastrarLivro_Click(object sender, RoutedEventArgs e)
        {
            frmCadastrarLivro form = new frmCadastrarLivro();
            form.ShowDialog();
        }

        
    }
}
