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
using AVfinal.entities;

namespace AVfinal.user_Controls
{
    public partial class checagemClientes : UserControl
    {
        public checagemClientes()
        {
            InitializeComponent();
        }

        private bool verificaTabela()
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            try
            {

                conn.Open();

                
                //ToDo
                
                

            } catch (Exception ex)
            {

            } finally
            {
                conn.Close();
            }

            return true;
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
            }
            else
            {
                btn_editar.Enabled = true;
            }

            try
            {
                conn.Open();

                str_command = "SELECT * FROM clientes";
                cmd = new MySqlCommand( str_command , conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Cliente> listClientes = new List<Cliente>();

                if (dataReader.HasRows)
                {
                    List<string> lista = new List<string>();
                    while(dataReader.Read())
                    {
                        
                        lista.Add(dataReader["id"] + "-" +dataReader["nome"] + "-" + dataReader["sexo"] + "-" + dataReader["telefone"] + "-" + dataReader["email"] + "-" + dataReader["nasc"].ToString().TrimEnd( new char[] {'0','0','0','0','0','0',':',':',':'}) + "-" + dataReader["cpf"]);
                    }

                    foreach (string frase in lista)
                    {
                        string[] palavras = frase.Split('-');
                        listClientes.Add(new Cliente(int.Parse(palavras[0]) , palavras[1] , char.Parse(palavras[2]) , palavras[3] , palavras[4] , palavras[5] , palavras[6]));
                    }

                    
                }
                dataReader.Close();
                dataGridView1.DataSource = listClientes;

            } catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);

            } finally
            {
                conn.Close();
            }


        }

        

        private void btn_att_Click(object sender, EventArgs e)
        {
            loadView();
        }

        private void checagemClientes_Load(object sender, EventArgs e)
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

                str_command = "SELECT * FROM clientes WHERE nome LIKE '%" + txtbox_nomeCliente.Text + "%';";

                cmd = new MySqlCommand(str_command , conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Cliente> listClientes = new List<Cliente>();

                if (dataReader.HasRows)
                {
                    List<string> lista = new List<string>();
                    while (dataReader.Read())
                    {
                        lista.Add(dataReader["id"] + "-" +dataReader["nome"] + "-" + dataReader["sexo"] + "-" + dataReader["telefone"] + "-" + dataReader["email"] + "-" + dataReader["nasc"].ToString().TrimEnd(new char[] { '0', '0', '0', '0', '0', '0', ':', ':', ':' }) + "-" + dataReader["cpf"]);
                    }

                    foreach (string palavra in lista)
                    {
                        string[] palavras = palavra.Split('-');
                        listClientes.Add(new Cliente(int.Parse(palavras[0]), palavras[1], char.Parse(palavras[2]), palavras[3], palavras[4], palavras[5] , palavras[6]));
                    }


                }
                dataReader.Close();
                dataGridView1.DataSource = listClientes;

                if (dataGridView1.Rows.Count < 1)
                {
                    btn_editar.Enabled = false;
                }
                else
                {
                    btn_editar.Enabled = true;
                }


            } catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            } finally
            {
                conn.Close();
                txtbox_nomeCliente.Text = null;
            }
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            Cliente cli = new Cliente();
                                        
            cli.Id = (int)dataGridView1.CurrentRow.Cells[0].Value;
            cli.Nome = (string)dataGridView1.CurrentRow.Cells[1].Value;
            cli.Sexo = (char)dataGridView1.CurrentRow.Cells[2].Value;
            cli.Email = (string)dataGridView1.CurrentRow.Cells[3].Value;
            cli.Telefone = (string)dataGridView1.CurrentRow.Cells[4].Value;            
            cli.Nasc = (string)dataGridView1.CurrentRow.Cells[5].Value;
            cli.Cpf = (string)dataGridView1.CurrentRow.Cells[6].Value;


            EditFormCliente edit = new EditFormCliente(cli);
            edit.Show();
                  
        }
    }
}
