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
    /// Interaction logic for frmCadastrarFuncionario.xaml
    /// </summary>
    public partial class frmCadastrarFuncionario : Window
    {
        public frmCadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void btnCadastrarFuncionario_Click(object sender, RoutedEventArgs e)
        {
           if(!string.IsNullOrWhiteSpace(txtNome.Text))
           {
               Funcionario funcionario = new Funcionario
               {
                   Nome = txtNome.Text,
                   Endereco = txtEndereco.Text,
                   Funcao = txtFuncao.Text,
                   Telefone = txtTelefone.Text,
                   Login = txtLogin.Text,
                   Senha = txtSenha.Text,
                   DataCadastro = DateTime.Now
               };
               if (FuncionarioDAO.AdicionarFuncionario(funcionario))
               {
                   MessageBox.Show("Funcionário Cadastrado com Sucesso");
               }
               else
               {
                   MessageBox.Show("Erro ao cadastrar Funcionário");
               }
           }
           else
           {
               MessageBox.Show("Favor Preencher os Campos");
           }
        }
        public void LimparCampos()
        {
            txtNome.Clear();
            txtEndereco.Clear();
            txtFuncao.Clear();
            txtTelefone.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
        }
    }
}
