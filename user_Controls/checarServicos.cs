using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AVfinal.DB;
using AVfinal.entities;

namespace AVfinal.user_Controls
{
    public partial class checarServicos : UserControl
    {
        public checarServicos()
        {
            InitializeComponent();
        }

        private void loadView()
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            if (dataGridView1.Rows.Count < 1)
            {
                btn_editar.Enabled = false;
            } else
            {
                btn_editar.Enabled = true;
            }

            try
            {
                conn.Open();

                str_command = "SELECT * FROM servicos";
                cmd = new MySqlCommand(str_command, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Servico> listServicos = new List<Servico>();

                if (dataReader.HasRows)
                {
                    List<string> lista = new List<string>();
                    while (dataReader.Read())
                    {

                        lista.Add(dataReader["id"] + "-" + dataReader["nome"] + "-" + dataReader["valor"]);
                    }

                    foreach (string palavra in lista)
                    {
                        string[] palavras = palavra.Split('-');
                        listServicos.Add(new Servico(int.Parse(palavras[0]) , palavras[1] , double.Parse(palavras[2])));
                    }


                }
                dataReader.Close();
                dataGridView1.DataSource = listServicos;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            }
            finally
            {
                conn.Close();
            }
        }


        private void checarServicos_Load(object sender, EventArgs e)
        {
            loadView();
        }

        private void btn_att_Click(object sender, EventArgs e)
        {
            loadView();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            try
            {
                conn.Open();

                str_command = "SELECT * FROM servicos WHERE nome LIKE '%" + txtbox_nomeServico.Text + "%';";

                cmd = new MySqlCommand(str_command, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Servico> listServicos = new List<Servico>();

                if (dataReader.HasRows)
                {
                    List<string> lista = new List<string>();
                    while (dataReader.Read())
                    {
                        lista.Add(dataReader["id"] + "-" + dataReader["nome"] + "-" + dataReader["valor"]);
                    }

                    foreach (string palavra in lista)
                    {
                        string[] palavras = palavra.Split('-');
                        listServicos.Add(new Servico(int.Parse(palavras[0]), palavras[1], double.Parse(palavras[2])));
                    }
                }
                dataReader.Close();
                dataGridView1.DataSource = listServicos;

                if (dataGridView1.Rows.Count < 1)
                {
                    btn_editar.Enabled = false;
                } else
                {
                    btn_editar.Enabled = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
            finally
            {
                conn.Close();
                txtbox_nomeServico.Text = null;
            }

        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Servico s = new Servico();

            
            s.Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            s.Nome = (string)dataGridView1.CurrentRow.Cells[1].Value;
            s.Valor = (double)dataGridView1.CurrentRow.Cells[2].Value;

            EditFormServico eServ = new EditFormServico(s);
            eServ.Show();
        }
    }
}
