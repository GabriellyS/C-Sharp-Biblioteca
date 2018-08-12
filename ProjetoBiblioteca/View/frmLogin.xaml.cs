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
    /// Interaction logic for frmLogin.xaml
    /// </summary>
    public partial class frmLogin : Window
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, RoutedEventArgs e)
        {
            /*Funcionario funcionario = new Funcionario{
                Login = txtLogin.Text,
                Senha = Convert.ToString(txtSenha)

            }*/
            if (string.IsNullOrWhiteSpace(txtLogin.Text) || string.IsNullOrWhiteSpace(Convert.ToString(txtSenha.Password)))
            {
                MessageBox.Show("Preencha todos os campos !");
            }
            else
            {
                if(AdministradorDAO.BuscarAdministradorPorLogin(txtLogin.Text, Convert.ToString(txtSenha.Password)) != false)
                {
                    frmPrincipal form = new frmPrincipal();
                    form.ShowDialog();
                }
                else if (FuncionarioDAO.BuscarFuncionarioPorLogin(txtLogin.Text, Convert.ToString(txtSenha.Password)) != false)
                {
                        
                }else{
                   MessageBox.Show("Login ou senha inválidos");
                }

         }
                 
     }
 }

