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
    public partial class registroServico : UserControl
    {
        public registroServico()
        {
            InitializeComponent();
        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;
            bool servicoExiste = false;

            try
            {
                conn.Open();

                str_command =
                    "CREATE TABLE if NOT EXISTS servicos(" +
                    "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                    "nome VARCHAR(99) NOT NULL," +
                    "valor DECIMAL(10,2) NOT NULL" +
                    ");";

                cmd = new MySqlCommand(str_command, conn);
                cmd.ExecuteNonQuery();

                string[] infos = new string[2];
                infos[0] = txtbox_nomeServico.Text;
                infos[1] = txtbox_valor.Text;

                str_command =
                    "SELECT * FROM servicos WHERE nome='" + infos[0] + "';";
                cmd = new MySqlCommand(str_command, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    servicoExiste = true;
                    Cadastrado cForm = new Cadastrado("Serviço Já Foi Cadastrado");
                    cForm.Show();
                }
                dataReader.Close();

                if (infos[0].Length >= 2 && infos[1].Length > 0)
                {
                    if (!servicoExiste)
                    {
                        str_command =
                            "INSERT INTO servicos (nome , valor) " +
                            "VALUES('" + infos[0] + "'," + infos[1] + ");";
                        cmd = new MySqlCommand(str_command, conn);
                        cmd.ExecuteNonQuery();

                        Cadastrado cForm = new Cadastrado("  Serviço Cadastrado com Sucesso!");
                        cForm.Show();
                    }
                } else
                {
                    Cadastrado cForm = new Cadastrado("  Requisitos Mínimos não cumpridos");
                    cForm.Show();
                }

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);

            } finally
            {
                conn.Close();
                txtbox_nomeServico.Text = null;
                txtbox_valor.Text = null;
            }
        }

        private void txtbox_valor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                if (e.KeyChar != 46)
                {
                    e.Handled = true;
                }
            }

        }

        private void registroServico_Load(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            try
            {
                conn.Open();

                str_command =
                    "CREATE TABLE if NOT EXISTS servicos(" +
                    "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                    "nome VARCHAR(99) NOT NULL," +
                    "valor DECIMAL(10,2) NOT NULL" +
                    ");";

                cmd = new MySqlCommand(str_command, conn);
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally { 
                conn.Close();
            }
        }
    }
}
