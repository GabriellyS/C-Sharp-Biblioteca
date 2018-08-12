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
    /// Interaction logic for frmCadastrarCliente.xaml
    /// </summary>
    public partial class frmCadastrarCliente : Window
    {
        public frmCadastrarCliente()
        {
            InitializeComponent();
            LimparCampos();
        }

        private void btnSalvar_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Cliente cliente = new Cliente
                {
                    Nome = txtNome.Text,
                    Endereco = txtEndereco.Text,
                    Telefone = txtTelefone.Text,
                    DataCadastro = DateTime.Now
                };
                if(ClienteDAO.AdicionarCliente(cliente))
                {
                    MessageBox.Show("Cliente Gravado com Sucesso!!");
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Cliente!!");
                }
            }
            else
            {
                MessageBox.Show("Favor Preencher todos os Campos!!");
            }
        }

        public void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
        }
    }
}
