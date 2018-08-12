using ProjetoBiblioteca.DAL;
using ProjetoBiblioteca.Model;
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
    /// Interaction logic for frmCadastrarBiblioteca.xaml
    /// </summary>
    public partial class frmCadastrarBiblioteca : Window
    {
        public frmCadastrarBiblioteca()
        {
            InitializeComponent();
            LimparCampos();
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Biblioteca biblioteca = new Biblioteca
                {
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    Telefone = txtTelefone.Text
                };
                if(BibliotecaDAO.AdicionarBiblioteca(biblioteca))
                {
                    MessageBox.Show("Biblioeca Adicionada com Sucesso");
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Biblioteca");
                }
            }
            else
            {
                MessageBox.Show("Preencha os Campos Corretamente");
            }
        }

        public void LimparCampos()
        {
            txtTelefone.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
        }
    }
}
