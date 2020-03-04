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
    public partial class home : UserControl
    {
        public home()
        {
            InitializeComponent();
        }

        private void loadView()
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            List<Agendamento> agendamentosList = new List<Agendamento>();
            List<Cliente> clientes = new List<Cliente>();
            List<Servico> servicos = new List<Servico>();

            try
            {
                conn.Open();



                string[] numeros = monthCalendarHome.SelectionRange.Start.ToString().Remove(monthCalendarHome.SelectionRange.Start.ToString().Length - 9).Replace('/' , '-').Split('-');
                //dd / mm / yyyy

                string data = numeros[2] + "-" + numeros[1] + "-" + numeros[0];


                str_command = 
                    "SELECT * FROM clientes;";
                cmd = new MySqlCommand(str_command , conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {

                    while (dataReader.Read())
                    {
                        Cliente cTemp = new Cliente();
                        cTemp.Id = int.Parse(dataReader["id"].ToString());
                        cTemp.Nome = dataReader["nome"].ToString();
                        cTemp.Sexo = char.Parse(dataReader["sexo"].ToString());
                        cTemp.Telefone = dataReader["telefone"].ToString();
                        cTemp.Email = dataReader["email"].ToString();
                        cTemp.Nasc = dataReader["nasc"].ToString();
                        cTemp.Cpf = dataReader["cpf"].ToString();

                        clientes.Add(cTemp);

                    }
                }
                dataReader.Close();


                str_command =
                    "SELECT * FROM servicos;";
                cmd = new MySqlCommand(str_command, conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        servicos.Add(new Servico(int.Parse(dataReader["id"].ToString()) , dataReader["nome"].ToString() , double.Parse(dataReader["valor"].ToString())));
                    }
                }
                dataReader.Close();


                str_command = 
                    "SELECT * FROM agendamentos " +
                    "WHERE data='"+data+"';";
                cmd = new MySqlCommand(str_command , conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {

                    List<string> frases = new List<string>();
                    while (dataReader.Read())
                    {
                        frases.Add(dataReader["id"]+"-"+dataReader["idClienteAgendado"]+"-"+dataReader["data"].ToString().Remove(dataReader["data"].ToString().Length - 9)+"-"+dataReader["horario"]+"-"+dataReader["ids_ServicosAgendados"]+"-"+dataReader["valorTotal"]);

                    }

                    foreach (string frase in frases)
                    {
                        string[] palavra = frase.Split('-');

                        Agendamento agendTemp = new Agendamento();

                        
                        agendTemp.Id = int.Parse(palavra[0]);
                        agendTemp.Data = palavra[2];
                        agendTemp.Hora = palavra[3];
                        agendTemp.ValorTotal = double.Parse(palavra[5]);

                        string[] ids = palavra[4].Split(',');

                        foreach (Cliente c in clientes)
                        {
                            if (c.Id == int.Parse(dataReader["idClienteAgendado"].ToString()))
                            {
                                agendTemp.ClienteAgendado = c.Nome;
                            }

                        }

                        foreach (Servico s in servicos)
                        {
                            foreach (string id in ids)
                            {
                                if (s.Id == int.Parse(id))
                                {
                                    agendTemp.Servs.Add(s);
                                }
                            } 
                        }
                        agendamentosList.Add(agendTemp);
                    }
                }
                dataReader.Close();
                dataGridView1.DataSource = agendamentosList;

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO "  + ex.Message);

            } finally
            {
                conn.Close();
            }



        }


        private void monthCalendarHome_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void criaTableClientes()
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

        private void criaTableAgendamentos()
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
        }

        private void criaTableServicos()
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

        private void home_Load(object sender, EventArgs e)
        {
            criaTableClientes();
            criaTableAgendamentos();
            criaTableServicos();
            loadView();
        }

        private void monthCalendarHome_DateSelected(object sender, DateRangeEventArgs e)
        {
            loadView();
        }

        private void concluded_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            try
            {
                conn.Open();

                str_command =
                    "DELETE FROM agendamentos " +
                    "WHERE id=" + (int)dataGridView1.CurrentRow.Cells[0].Value + ";";
                cmd = new MySqlCommand(str_command , conn);
                cmd.ExecuteNonQuery();

                loadView();

            } catch (Exception ex)
            {
                MessageBox.Show("erro " + ex.Message);

            } finally
            {
                conn.Close();
            }

        }
    }
}
