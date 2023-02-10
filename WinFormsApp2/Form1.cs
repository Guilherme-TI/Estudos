using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System.Data;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string caminho = "datasource=localhost; username=root; password=; database=chat";
        public Form1()
        {
            InitializeComponent();
        }

        private void acessar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(caminho);
                Conexao.Open();
                string sql = "SELECT * FROM usuarios WHERE usuario = @usuario AND senha = @senha";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if(dt.Rows.Count > 0 )
                {
                    Inicio inicio = new Inicio();
                    inicio.Show();
                    Hide();
                }
                else
                {
                    MessageBox.Show("Usuario ou Senha Incorretos");
                }

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

        private void cadastrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cadastro cadastro = new Cadastro();
            cadastro.Show();
            Hide();
        }
    }
}