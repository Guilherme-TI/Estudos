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
    public partial class Cadastro : Form
    {
        private MySqlConnection Conexao;
        private string caminho = "datasource=localhost; username=root; password=; database=chat";
        public Cadastro()
        {
            InitializeComponent();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(caminho);
                Conexao.Open();
                string sql = "INSERT INTO usuarios (usuario, senha) VALUES (@usuario, @senha)";
                MySqlCommand cmd = new MySqlCommand(sql, Conexao);
                cmd.Parameters.AddWithValue("@usuario", txtUsuario.Text);
                cmd.Parameters.AddWithValue("@senha", txtSenha.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Cadastro realizado com sucesso");
                Form1 form1= new Form1();
                form1.Show();
                Hide();
                Conexao.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            Hide();
        }
    }
}
