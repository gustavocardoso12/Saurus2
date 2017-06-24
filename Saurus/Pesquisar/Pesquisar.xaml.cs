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
namespace Saurus.Pesquisar
{
    /// <summary>
    /// Interaction logic for Pesquisar.xaml
    /// </summary>
    public partial class Pesquisar : Page
    {
        public Pesquisar()
        {
            InitializeComponent();

        }

        private void Rbn_Numero_Checked(object sender, RoutedEventArgs e)
        {
            // tornando o controle numero visível e os outros ficam escondidos, todos são esvaziados
            numero_internoTextBox.Visibility = Visibility.Visible;
            numero_internoTextBox.Text = "";
            cPFTextBox.Visibility = Visibility.Hidden;
            cPFTextBox.Text = "";
            data_NascimentoDatePicker.Visibility = Visibility.Hidden;
            data_NascimentoDatePicker.Text = "";
            nomeTextBox.Visibility = Visibility.Hidden;
            nomeTextBox.Text = "";
        }

        private void Rbn_CPF_Checked(object sender, RoutedEventArgs e)
        {
            // tornando o controle cpf visível e os outros ficam escondidos, todos são esvaziados
            numero_internoTextBox.Visibility = Visibility.Hidden;
            numero_internoTextBox.Text = "";
            cPFTextBox.Visibility = Visibility.Visible;
            cPFTextBox.Text = "";
            data_NascimentoDatePicker.Visibility = Visibility.Hidden;
            data_NascimentoDatePicker.Text = "";
            nomeTextBox.Visibility = Visibility.Hidden;
            nomeTextBox.Text = "";
        }

        private void Rbn_Nome_Checked(object sender, RoutedEventArgs e)
        {
            // tornando o controle nome visível e os outros ficam escondidos, todos são esvaziados
            numero_internoTextBox.Visibility = Visibility.Hidden;
            numero_internoTextBox.Text = "";
            cPFTextBox.Visibility = Visibility.Hidden;
            cPFTextBox.Text = "";
            data_NascimentoDatePicker.Visibility = Visibility.Hidden;
            data_NascimentoDatePicker.Text = "";
            nomeTextBox.Visibility = Visibility.Visible;
            nomeTextBox.Text = "";
        }

        private void Rbn_Data_Checked(object sender, RoutedEventArgs e)
        {
            // tornando o controle data visível e os outros ficam escondidos, todos são esvaziados
            numero_internoTextBox.Visibility = Visibility.Hidden;
            cPFTextBox.Text = "";
            cPFTextBox.Visibility = Visibility.Hidden;
            data_NascimentoDatePicker.Visibility = Visibility.Visible;
            data_NascimentoDatePicker.Text = "";
            nomeTextBox.Visibility = Visibility.Hidden;
            nomeTextBox.Text = "";
        }

        private void Pesquisarbtn_Click(object sender, RoutedEventArgs e)
        {
            try {
                if (Rbn_Numero.IsChecked == true)
                {
                    //lendo pelo número interno
                    string conexao_string = "Data Source=(LocalDB)\\Saurus;AttachDbFilename=|DataDirectory|\\Saurus_BD.mdf;Integrated Security=True;Connect Timeout=30";
                    SqlConnection conexao = new SqlConnection(conexao_string);
                    string sql = "select * from Cliente where Numero_interno = @Numero_interno ";

                    SqlCommand comando = new SqlCommand(sql, conexao);
                    comando.Parameters.Add(new SqlParameter("@Numero_interno", this.numero_internoTextBox.Text));

                    conexao.Open();
                    comando.ExecuteNonQuery();


                    SqlDataReader leitor = comando.ExecuteReader();


                    if (leitor.HasRows)
                    {
                        //lendo e atribuindo os valores da consulta nos textboxs
                        leitor.Read();
                        var num_int = leitor["Numero_interno"];
                        var cpf = leitor["CPF"];
                        var nome = leitor["Nome"];
                        var data = leitor["Data_Nascimento"];
                        numero_internoTextBox.Text = num_int.ToString();
                        cPFTextBox.Text = cpf.ToString();
                        nomeTextBox.Text = nome.ToString();
                        //tornando os controles visíveis
                        data_NascimentoDatePicker.Text = data.ToString();
                        numero_internoTextBox.Visibility = Visibility.Visible;
                        cPFTextBox.Visibility = Visibility.Visible;
                        data_NascimentoDatePicker.Visibility = Visibility.Visible;
                        nomeTextBox.Visibility = Visibility.Visible;
                        MessageBox.Show("Pesquisa concluída", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                        conexao.Close();
                        //colocando máscara no cpf
                        string result = "";
                        if (cPFTextBox.Text.Length == 11)
                        {
                            result = cPFTextBox.Text.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                            cPFTextBox.Text = result;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Registro não encontrado", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
                else
                {
                    if (Rbn_CPF.IsChecked == true)
                    {
                        //lendo pelo cpf
                        string conexao_string = "Data Source=(LocalDB)\\Saurus;AttachDbFilename=|DataDirectory|\\Saurus_BD.mdf;Integrated Security=True;Connect Timeout=30";
                        SqlConnection conexao_cpf = new SqlConnection(conexao_string);
                        string sql_cpf = "select * from Cliente where CPF = @CPF";

                        SqlCommand comando_cpf = new SqlCommand(sql_cpf, conexao_cpf);
                        comando_cpf.Parameters.Add(new SqlParameter("@CPF", this.cPFTextBox.Text));
                        conexao_cpf.Open();
                        comando_cpf.ExecuteNonQuery();
                        int pos_cpf = int.Parse(comando_cpf.ExecuteScalar().ToString());
                        SqlDataReader leitor = comando_cpf.ExecuteReader();

                        if (leitor.HasRows)
                        {
                            //lendo e atribuindo os valores das consultas nos textbox
                            leitor.Read();
                            var num_int = leitor["Numero_interno"];
                            var cpf = leitor["CPF"];
                            var nome = leitor["Nome"];
                            var data = leitor["Data_Nascimento"];
                            numero_internoTextBox.Text = num_int.ToString();
                            cPFTextBox.Text = cpf.ToString();
                            nomeTextBox.Text = nome.ToString();
                            //tornando os controles visíveis

                            data_NascimentoDatePicker.Text = data.ToString();
                            numero_internoTextBox.Visibility = Visibility.Visible;
                            cPFTextBox.Visibility = Visibility.Visible;
                            data_NascimentoDatePicker.Visibility = Visibility.Visible;
                            nomeTextBox.Visibility = Visibility.Visible;
                            MessageBox.Show("Pesquisa concluída", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                            conexao_cpf.Close();
                            string result = "";
                            //colocando mascara no cpf
                            if (cPFTextBox.Text.Length == 11)
                            {
                                result = cPFTextBox.Text.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                                cPFTextBox.Text = result;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Registro não encontrado", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                        }

                    }
                    else
                    {
                       

                        if (Rbn_Data.IsChecked == true)
                        {
                            //lendo pela data
                            string conexao_string = "Data Source=(LocalDB)\\Saurus;AttachDbFilename=|DataDirectory|\\Saurus_BD.mdf;Integrated Security=True;Connect Timeout=30";
                            SqlConnection conexao_data = new SqlConnection(conexao_string);
                            string sql_data = "select * from Cliente where Data_Nascimento = @Data_Nascimento ";

                            SqlCommand comando_data = new SqlCommand(sql_data, conexao_data);
                            MessageBox.Show("" + data_NascimentoDatePicker.DisplayDate);
                          
                            comando_data.Parameters.Add(new SqlParameter("@Data_Nascimento",this.data_NascimentoDatePicker.DisplayDate));
                            conexao_data.Open();

                            comando_data.ExecuteNonQuery();
                            SqlDataReader leitor = comando_data.ExecuteReader();


                            if (leitor.HasRows)
                            {
                                //lendo e atribuindo os valores da consulta nas textboxs
                                leitor.Read();
                                var num_int = leitor["Numero_interno"];
                                var cpf = leitor["CPF"];
                                var nome = leitor["Nome"];
                                var data = leitor["Data_Nascimento"];
                                numero_internoTextBox.Text = num_int.ToString();
                                cPFTextBox.Text = cpf.ToString();
                                nomeTextBox.Text = nome.ToString();
                                data_NascimentoDatePicker.Text = data.ToString();

                                //tornando os controles visiveis
                                numero_internoTextBox.Visibility = Visibility.Visible;
                                cPFTextBox.Visibility = Visibility.Visible;
                                data_NascimentoDatePicker.Visibility = Visibility.Visible;
                                nomeTextBox.Visibility = Visibility.Visible;
                                MessageBox.Show("Pesquisa concluída", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                                conexao_data.Close();
                                //inserindo mascara no cpf
                                string result = "";
                                if (cPFTextBox.Text.Length == 11)
                                {
                                    result = cPFTextBox.Text.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                                    cPFTextBox.Text = result;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                            }

                        }
                        else
                        {
                            //busca pelo nome
                            string conexao_string = "Data Source=(LocalDB)\\Saurus;AttachDbFilename=|DataDirectory|\\Saurus_BD.mdf;Integrated Security=True;Connect Timeout=30";
                            SqlConnection conexao_nome = new SqlConnection(conexao_string);
                            string sql_nome = "select * from Cliente where Nome = @Nome ";
                            SqlCommand comando_nome = new SqlCommand(sql_nome, conexao_nome);
                            comando_nome.Parameters.Add(new SqlParameter("@Nome", this.nomeTextBox.Text));
                            conexao_nome.Open();
                            comando_nome.ExecuteNonQuery();


                            int pos_nome = int.Parse(comando_nome.ExecuteScalar().ToString());

                            SqlDataReader leitor = comando_nome.ExecuteReader();

                            if (leitor.HasRows)
                            {
                                //lendo e colocando em variaveis, depois nos textbox as informações das consultas
                                leitor.Read();
                                var num_int = leitor["Numero_interno"];
                                var cpf = leitor["CPF"];
                                var nome = leitor["Nome"];
                                var data = leitor["Data_Nascimento"];
                                numero_internoTextBox.Text = num_int.ToString();
                                cPFTextBox.Text = cpf.ToString();
                                nomeTextBox.Text = nome.ToString();
                                data_NascimentoDatePicker.Text = data.ToString();

                                //tornando os controles preenchidos visíveis
                                numero_internoTextBox.Visibility = Visibility.Visible;
                                cPFTextBox.Visibility = Visibility.Visible;
                                data_NascimentoDatePicker.Visibility = Visibility.Visible;
                                nomeTextBox.Visibility = Visibility.Visible;

                                MessageBox.Show("Pesquisa concluída", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                                conexao_nome.Close();
                                //colocando digitos de máscara no CPF
                                string result = "";
                                if (cPFTextBox.Text.Length == 11)
                                {
                                    result = cPFTextBox.Text.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                                    cPFTextBox.Text = result;
                                }
                            }
                            else
                            {
                                MessageBox.Show("Registro não encontrado", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                            }

                        }
                    }
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
            }



        }

    }
    }

       
    

        

