using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Inicio : Form
    {
        private MySqlConnection Conexao;
        private string caminho = "datasource=localhost; username=root; password=; database=chat";
        public Inicio()
        {
            InitializeComponent();
        }

        private void viewMensagem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void exibir_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(caminho);
                Conexao.Open();
                string sql = "SELECT conteudo FROM mensagens";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                viewMensagem.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(caminho);
                Conexao.Open();
                string sql = "INSERT INTO mensagens (conteudo, id_usuario) VALUES (@conteudo, @id)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@conteudo", txtMensagem.Text);
                cmd.Parameters.AddWithValue("@id", txtId.Text);
                cmd.ExecuteNonQuery();

                txtMensagem.Text = "";
                txtId.Text = "";

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}
