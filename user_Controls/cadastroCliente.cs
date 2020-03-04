using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AVfinal.DB;
using MySql.Data.MySqlClient;
using AVfinal.util_forms;

namespace AVfinal.user_Controls
{
    public partial class cadastroCliente : UserControl
    {
        public cadastroCliente()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;
            bool usuarioCadastrado = false;

            try
            {
                conn.Open();

                str_command = "CREATE TABLE if NOT EXISTS clientes(" +
                    "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                    "nome VARCHAR(99) NOT NULL," +
                    "sexo VARCHAR(10)," +
                    "telefone VARCHAR(15)," +
                    "email VARCHAR(99)," +
                    "nasc DATE," +
                    "cpf VARCHAR(15)" +
                    ");";
                cmd = new MySqlCommand(str_command, conn);
                cmd.ExecuteNonQuery();
                str_command = null;

                string[] infos = new string[6];
                infos[0] = txtbox_nomeCompleto.Text;
                infos[1] = combobox_sexo.Text;
                infos[2] = txtbox_telefone.Text;
                infos[3] = txtbox_email.Text;
                infos[4] = dateTimePicker_aniversario.Text;
                infos[5] = txtbox_cpf.Text;

                str_command = "SELECT * FROM clientes WHERE email= '" + infos[3] + "';";
                cmd = new MySqlCommand(str_command, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    usuarioCadastrado = true;
                    Cadastrado clForm = new Cadastrado("Cliente Já tem Cadastro");
                    clForm.Show();

                }
                dataReader.Close();

                if(txtbox_nomeCompleto.Text.Length < 2 || txtbox_email.Text.Length < 5)
                {
                    Cadastrado clForm = new Cadastrado("Valores Invalidos!");
                    clForm.Show();
                }


                if (usuarioCadastrado == false) {
                    str_command =
                            "INSERT INTO clientes (nome , sexo , telefone , email , nasc , cpf) " +
                            "VALUES(" +
                            "'" + infos[0] + "'," +
                            "'" + infos[1] + "'," +
                            "'" + infos[2] + "'," +
                            "'" + infos[3] + "'," +
                            "'" + infos[4] + "'," +
                            "'" + infos[5] + "');";


                    cmd = new MySqlCommand(str_command, conn);
                    cmd.ExecuteNonQuery();

                    Cadastrado clForm = new Cadastrado("Cliente Cadastrado Com Sucesso");
                    clForm.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            }
            finally
            {
                conn.Close();
                txtbox_nomeCompleto.Text = null;
                combobox_sexo.Text = null;
                txtbox_telefone.Text = null;
                txtbox_email.Text = null;
                dateTimePicker_aniversario.Text = null;
                txtbox_cpf.Text = null;
            }
        }

        private void txtbox_cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void txtbox_telefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }
        }

        private void combobox_sexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != 08)
            {
                e.Handled = true;
            }

        }

        private void cadastroCliente_Load(object sender, EventArgs e)
        {

            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            try
            {
                conn.Open();

                str_command = 
                    "CREATE TABLE if NOT EXISTS clientes(" +
                    "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                    "nome VARCHAR(99) NOT NULL," +
                    "sexo VARCHAR(10)," +
                    "telefone VARCHAR(15)," +
                    "email VARCHAR(99)," +
                    "nasc DATE," +
                    "cpf VARCHAR(15)" +
                    ");";

                cmd = new MySqlCommand(str_command, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                conn.Close();
            }


        }
    }
}
