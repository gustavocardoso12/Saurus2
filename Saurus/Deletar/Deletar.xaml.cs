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
namespace Saurus.Deletar
{
    /// <summary>
    /// Interaction logic for Deletar.xaml
    /// </summary>
    public partial class Deletar : Page
    {
        public Deletar()
        {
            InitializeComponent();
            // carregando os dados da tabela
            Saurus.Saurus_BDDataSet saurus_BDDataSet = ((Saurus.Saurus_BDDataSet)(this.FindResource("saurus_BDDataSet")));
            // Load data into the table Cliente. You can modify this code as needed.
            Saurus.Saurus_BDDataSetTableAdapters.ClienteTableAdapter saurus_BDDataSetClienteTableAdapter = new Saurus.Saurus_BDDataSetTableAdapters.ClienteTableAdapter();
            saurus_BDDataSetClienteTableAdapter.Fill(saurus_BDDataSet.Cliente);
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
            clienteViewSource.View.MoveCurrentToFirst();
        }

        private void Deletarbtn_Click(object sender, RoutedEventArgs e)
        {
            try {
                //deletando os dados segundo seu número interno
                string conexao_string = "Data Source=H;Initial Catalog=Saurus_Banco;Integrated Security=True";
                SqlConnection conexao = new SqlConnection(conexao_string);
                string sql = "Delete from Saurus_tabela_clientes where Numero_interno = @Numero_interno";
                SqlCommand comando = new SqlCommand(sql, conexao);
                comando.Parameters.Add(new SqlParameter("@Numero_interno", this.numero_internoTextBox.Text));
                conexao.Open();
                comando.ExecuteNonQuery();
                cPFTextBox.Text = "";
                nomeTextBox.Text = "";
                data_NascimentoDatePicker.Text = "";
                MessageBox.Show("Deleção concluída","Aviso",MessageBoxButton.OK,MessageBoxImage.Information);
                conexao.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro de deleção", "Alerta", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void anterior_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
           clienteViewSource.View.MoveCurrentToPrevious();
        }

        private void Proximo_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource clienteViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("clienteViewSource")));
            clienteViewSource.View.MoveCurrentToNext();
        }

        private void cPFTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
