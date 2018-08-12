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
    /// Interaction logic for frmCadastrarLivro.xaml
    /// </summary>
    public partial class frmCadastrarLivro : Window
    {
        public frmCadastrarLivro()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            cboBibliotecas.ItemsSource = BibliotecaDAO.RetornarLista();
            cboBibliotecas.DisplayMemberPath = "Nome";
            cboBibliotecas.SelectedValuePath = "BibliotecaId";

            //Biblioteca b = (Biblioteca)cboBibliotecas.SelectedItem;
           
        }

        private void btnGravar_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtNome.Text))
            {
                Biblioteca b = (Biblioteca)cboBibliotecas.SelectedItem;
                Livro livro = new Livro
                {
                    Nome = txtNome.Text,
                    Genero = txtGenero.Text,
                    Biblioteca = b,
                    Ano = txtAno.Text,
                    Edicao = txtEdicao.Text,
                    Editora = txtEditora.Text,
                    Escritor = txtEscritor.Text,
                    DataCadastro = DateTime.Now

                };
                if (LivroDAO.AdicionarLivro(livro))
                {
                    MessageBox.Show("Livro Cadastrao com Sucesso!!");
                }
                else
                {
                    MessageBox.Show("Erro ao Cadastrar Livro!!");
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos Corretamente");
            }
        }

        public void LimparCampos()
        {
            txtAno.Clear();
            txtEdicao.Clear();
            txtEditora.Clear();
            txtEscritor.Clear();
            txtGenero.Clear();
            txtNome.Clear();
            
        }
    }
}
