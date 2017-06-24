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
namespace Saurus.Atualizar
{
    /// <summary>
    /// Interaction logic for atualizar.xaml
    /// </summary>
    public partial class atualizar : Page
    {
        public atualizar()
        {
            InitializeComponent();
            //preenchendo a base de dados

            Saurus.Saurus_BDDataSet saurus_BDDataSet = ((Saurus.Saurus_BDDataSet)(this.FindResource("saurus_BDDataSet")));
            // Load data into the table Cliente. You can modify this code as needed.
            Saurus.Saurus_BDDataSetTableAdapters.ClienteTableAdapter saurus_BDDataSetClienteTableAdapter = new Saurus.Saurus_BDDataSetTableAdapters.ClienteTableAdapter();
            saurus_BDDataSetClienteTableAdapter.Fill(saurus_BDDataSet.Cliente);
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
            clienteViewSource.View.MoveCurrentToFirst();
        }

        private void saurus_tabela_clientesDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void saurus_tabela_clientesDataGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            //passando para o próximo
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
            clienteViewSource.View.MoveCurrentToNext();
            if (cPFTextBox.Text == "")
            {
                MessageBox.Show("final da lista","aviso",MessageBoxButton.OK,MessageBoxImage.Exclamation);
            }
        }

      

        private void anterior_Click(object sender, RoutedEventArgs e)
        {
            //passa para o registro anterior
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
            clienteViewSource.View.MoveCurrentToPrevious();
        }

        private void Atualizar_Click(object sender, RoutedEventArgs e)
        {
            try {
                //atualizando os valores, pode ser qualquer um deles
                string conexao_string = "Data Source=H;Initial Catalog=Saurus_Banco;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(conexao_string);

                string sql = "UPDATE Saurus_tabela_clientes SET CPF = @CPF, Nome = @Nome, Data_Nascimento = @Data_Nascimento WHERE Numero_interno = @Numero_interno";


                if (Validacao.ValidaCPF.IsCpf(cPFTextBox.Text))
                {
                    SqlCommand comando = new SqlCommand(sql, conexao);
                    comando.Parameters.Add(new SqlParameter("@Numero_interno", this.numero_internoTextBox.Text));
                    comando.Parameters.Add(new SqlParameter("@CPF", this.cPFTextBox.Text));
                    comando.Parameters.Add(new SqlParameter("@Nome", this.nomeTextBox.Text));
                    comando.Parameters.Add(new SqlParameter("@Data_Nascimento", this.data_NascimentoDatePicker.Text));


                    conexao.Open();
                    comando.ExecuteNonQuery();
                    MessageBox.Show("Atualização bem sucedida", "Aviso", MessageBoxButton.OK, MessageBoxImage.Information);
                    // colocando máscara no cpf
                    string result = "";
                    if (cPFTextBox.Text.Length == 11)
                    {
                        result = cPFTextBox.Text.Insert(3, ".").Insert(7, ".").Insert(11, "-");
                        cPFTextBox.Text = result;
                    }
                }
                else
                {
                    MessageBox.Show("cpf invalido","Alerta",MessageBoxButton.OK,MessageBoxImage.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro na atualização ou os campos são nulos", "Alerta", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void cPFTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }
    }
}
