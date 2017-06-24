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
using System.Data.SqlClient;

namespace Saurus.Inserir
{
    /// <summary>
    /// Interaction logic for Inserir.xaml
    /// </summary>
    public partial class Inserir : Page
    {
        public Inserir()
        {
            InitializeComponent();
           
        }

        private void Inserirbtn_Click(object sender, RoutedEventArgs e)
        {
            try {
                string conexao_string = "Data Source=(LocalDB)\\Saurus;AttachDbFilename=|DataDirectory|\\Saurus_BD.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection conexao = new SqlConnection(conexao_string);
                // se os valores estiverem vazios
                if ((cPFTextBox.Text == "") || (NomeTextBox.Text == "") || (data.Text == "01/01/1900"))
                {
                    MessageBox.Show("campos vazios", "alerta", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    // se for o cpf valido
                    if (Validacao.ValidaCPF.IsCpf(cPFTextBox.Text))
                    {
                        //insere os valores dos textboxs na tabela
                        SqlCommand comando_insercao = new SqlCommand("Insert into Cliente  Values('" + cPFTextBox.Text + "','" + NomeTextBox.Text + "','" + data.DisplayDate + "')", conexao);
                        conexao.Open();
                        comando_insercao.ExecuteNonQuery();
                        MessageBox.Show("Inserção bem sucedida", "aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                        //colocando a máscara no cpf
                        string result = "";
                        if (cPFTextBox.Text.Length == 11)
                        {
                            result = cPFTextBox.Text.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                            cPFTextBox.Text = result;
                        }

                    }
                    else
                    {
                        MessageBox.Show("CPF Inválido","Erro",MessageBoxButton.OK,MessageBoxImage.Error);
                    }

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cPFTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            

        }
    }
    }

