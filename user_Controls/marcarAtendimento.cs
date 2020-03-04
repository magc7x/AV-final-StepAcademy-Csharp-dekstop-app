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
using AVfinal.util_forms;

namespace AVfinal.user_Controls
{
    public partial class marcarAtendimento : UserControl
    {
        private BindingList<Servico> servs = new BindingList<Servico>();
        private double valor;

        public marcarAtendimento()
        {
            InitializeComponent();
        }

        private void resetServs()
        {
            servs = new BindingList<Servico>();
            dataGridView1.Rows.Clear();
            valor = 0;
            lbl_valor.Text = valor.ToString();

        }

        private void loadComboBoxClientes()
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;


            try
            {
                conn.Open();

                str_command =
                    "SELECT * FROM clientes;";
                cmd = new MySqlCommand( str_command , conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Cliente> listClientes = new List<Cliente>();

                if (dataReader.HasRows)
                {
                    List<string> lista = new List<string>();
                    while(dataReader.Read())
                    {
                        lista.Add(dataReader["id"] + "-" +dataReader["nome"] + "-" + dataReader["sexo"] + "-" + dataReader["telefone"] + "-" + dataReader["email"] + "-" + dataReader["nasc"] + "-" + dataReader["cpf"]);
                    }

                    foreach (string frase in lista)
                    {
                        string[] palavras = frase.Split('-');
                        listClientes.Add(new Cliente(int.Parse(palavras[0]), palavras[1], char.Parse(palavras[2]), palavras[3], palavras[4], palavras[5], palavras[6]));
                    }

                }
                dataReader.Close();

                combobox_cliente.Items.Clear();

                foreach (Cliente c in listClientes)
                {
                    combobox_cliente.Items.Add(c.Id +" - "+c.Nome);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void loadGridViewServicos()
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            try
            {
                conn.Open();

                str_command =
                    "SELECT * FROM servicos;";
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

                    foreach (string frase in lista)
                    {
                        string[] palavras = frase.Split('-');
                        listServicos.Add(new Servico(int.Parse(palavras[0]) , palavras[1] , double.Parse(palavras[2])));
                    }

                }
                dataReader.Close();

                gridViewServicos.DataSource = listServicos;

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);
            } finally
            {
                conn.Close();
            }
        }

        private void enableAndDisableBtn()
        {
            if (gridViewServicos.Rows.Count > 0 && combobox_cliente.Text.Length > 5 && combobox_hora.Text.Length > 3)
            {
                btn_agendar.Enabled = true;
            } else
            {
                btn_agendar.Enabled = false;
            }
        }

        private void btn_agendar_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            try
            {
                conn.Open();

                str_command = 
                    "CREATE TABLE if NOT EXISTS agendamentos(" +
                    "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                    "idClienteAgendado INT NOT NULL," +
                    "data DATE NOT NULL," +
                    "horario VARCHAR(10) NOT NULL," +
                    "ids_ServicosAgendados VARCHAR(50) NOT NULL," +
                    "valorTotal DECIMAL(10,2) NOT NULL" +
                    ");";
                cmd = new MySqlCommand(str_command , conn);
                cmd.ExecuteNonQuery();


                string[] infos = new string[4];
                string[] clienteIdNome = combobox_cliente.Text.Split('-');
                infos[0] = clienteIdNome[0];
                infos[1] = daTime_data.Text;
                infos[2] = combobox_hora.Text;
                infos[3] = servs[0].Id.ToString();

                for (int i=0; i<servs.Count; i++)
                {
                    if (i > 0)
                    {
                        infos[3] += "," + servs[i].Id.ToString();
                    }
                }


                str_command =
                    "INSERT INTO agendamentos (idClienteAgendado,data,horario,ids_ServicosAgendados,valorTotal) " +
                    "VALUES(" +
                    ""+infos[0]+"," +
                    "'"+infos[1]+"'," +
                    "'"+infos[2]+"'," +
                    "'"+infos[3]+"'," +
                    ""+lbl_valor.Text+"" +
                    ");";
                cmd = new MySqlCommand(str_command , conn);
                cmd.ExecuteNonQuery();

                Cadastrado clForm = new Cadastrado("Agendamento Realizado");
                clForm.Show();


            } catch (Exception ex)
            {
                MessageBox.Show("ERRO" + ex.Message);

            } finally
            {
                conn.Close();
                combobox_cliente.Text = null;
                combobox_hora.Text = null;
                resetServs();
            }
        }

        private void marcarAtendimento_Load(object sender, EventArgs e)
        {
            
                db_conn db = new db_conn();
                MySqlConnection conn = db.getConn();
                MySqlCommand cmd;
                string str_command;

                try
                {
                    conn.Open();

                    str_command =
                    "CREATE TABLE if NOT EXISTS agendamentos(" +
                    "id INT PRIMARY KEY NOT NULL AUTO_INCREMENT," +
                    "idClienteAgendado INT NOT NULL," +
                    "data DATE NOT NULL," +
                    "horario VARCHAR(10) NOT NULL," +
                    "ids_ServicosAgendados VARCHAR(50) NOT NULL," +
                    "valorTotal DECIMAL(10,2) NOT NULL" +
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



            loadComboBoxClientes();
            loadGridViewServicos();
            enableAndDisableBtn();
        }

        private void combobox_cliente_MouseClick(object sender, MouseEventArgs e)
        {
            loadComboBoxClientes();
            loadGridViewServicos();           
            enableAndDisableBtn();
        }

        private void combobox_cliente_TextChanged(object sender, EventArgs e)
        {
            enableAndDisableBtn();
            resetServs();
        }

        private void combobox_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combobox_hora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combobox_hora_TextChanged(object sender, EventArgs e)
        {
            enableAndDisableBtn();
        }

        private void select_btn_Click(object sender, EventArgs e)
        {
                                    
            Servico s = new Servico();
            s.Id = (int)gridViewServicos.CurrentRow.Cells[0].Value;
            s.Nome = (string)gridViewServicos.CurrentRow.Cells[1].Value;
            s.Valor = (double)gridViewServicos.CurrentRow.Cells[2].Value;
            servs.Add(s);

            valor += (double)gridViewServicos.CurrentRow.Cells[2].Value;
            if (valor < 0) valor = 0;
            lbl_valor.Text = valor.ToString();
               
            dataGridView1.DataSource = servs;
      
           
        }

        private void btn_removeServ_Click(object sender, EventArgs e)
        {
           
            int index = dataGridView1.Rows.Count;
            if (index > 1)
            {
                valor -= (double)dataGridView1.CurrentRow.Cells[2].Value;
                if (valor < 0) valor = 0;

                lbl_valor.Text = valor.ToString();

                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }
    }
}
