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
    public partial class checarAgendamentos : UserControl
    {
        public checarAgendamentos()
        {
            InitializeComponent();
        }

        private void loadView()
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            List<Cliente> cli = new List<Cliente>();
            List<Servico> serv = new List<Servico>();
            List<Agendamento> agendamentos = new List<Agendamento>();

            try
            {
                conn.Open();

                str_command =
                    "SELECT * FROM clientes;";
                cmd = new MySqlCommand(str_command , conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<string> frases = new List<string>();
                    while (dataReader.Read())
                    {
                        frases.Add(dataReader["id"]+"-"+dataReader["nome"]+"-"+dataReader["sexo"]+"-"+dataReader["telefone"]+"-"+dataReader["email"]+"-"+dataReader["nasc"].ToString().Remove(dataReader["nasc"].ToString().Length - 8)+"-"+dataReader["cpf"]);

                    }

                    foreach (string frase in frases)
                    {
                        string[] palavras = frase.Split('-');
                        cli.Add(new Cliente(int.Parse(palavras[0]) , palavras[1] , char.Parse(palavras[2]) , palavras[3] , palavras[4] , palavras[5] , palavras[6]));
                    }
                }
                dataReader.Close();


                str_command =
                    "SELECT * FROM servicos;";
                cmd = new MySqlCommand(str_command, conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<string> frases = new List<string>();
                    while (dataReader.Read())
                    {
                        frases.Add(dataReader["id"] + "-" + dataReader["nome"] + "-" + dataReader["valor"]);

                    }

                    foreach (string frase in frases)
                    {
                        string[] palavras = frase.Split('-');
                        serv.Add(new Servico(int.Parse(palavras[0]) , palavras[1] , double.Parse(palavras[2]) ));
                    }
                }
                dataReader.Close();



                str_command =
                    "SELECT * FROM agendamentos;";
                cmd = new MySqlCommand(str_command , conn);
                dataReader = cmd.ExecuteReader();

                if(dataReader.HasRows)
                {
                    List<string> frases = new List<string>();
                    while (dataReader.Read())
                    {
                        frases.Add(dataReader["id"]+"-"+dataReader["idClienteAgendado"]+"-"+dataReader["data"].ToString().Remove(dataReader["data"].ToString().Length - 9)+"-"+dataReader["horario"]+"-"+dataReader["ids_ServicosAgendados"]+"-"+dataReader["valorTotal"]);
                    }

                    foreach (string frase in frases)
                    {
                        string[] palavras = frase.Split('-');
                        string[] idServicos = palavras[4].Split(',');

                        Agendamento agend = new Agendamento();

                        agend.Id = int.Parse(palavras[0]);
                        agend.Data = palavras[2];
                        agend.Hora = palavras[3];
                        agend.ValorTotal = double.Parse(palavras[5]);

                        foreach (Cliente cliente in cli)
                        {
                            if (cliente.Id == int.Parse(palavras[1]))
                            {
                                agend.ClienteAgendado = cliente.Nome;
                                break;
                            }
                        }

                        foreach (string idServ in idServicos)
                        {
                            foreach (Servico sTemp in serv)
                            {
                                if (sTemp.Id == int.Parse(idServ))
                                {
                                    agend.Servs.Add(sTemp);
                                }
                            }
                        }

                        agendamentos.Add(agend);                    
                    }

                }
                dataReader.Close();
                dataGridView1.DataSource = agendamentos;



            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);
            } finally
            {
                conn.Close();
            }
        }

        private void checarAgendamentos_Load(object sender, EventArgs e)
        {
            loadView();
        }

        private void btn_att_Click(object sender, EventArgs e)
        {
            loadView();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            int id = (int) dataGridView1.CurrentRow.Cells[0].Value;

            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;

            Agendamento agendado = new Agendamento();
            int idClienteAgendadoA = 0;
            List<int> servicosAgendados = new List<int>();
            List<Servico> servicos = new List<Servico>();

            try
            {
                conn.Open();

                str_command =
                    "SELECT * FROM agendamentos WHERE id="+id+";";

                cmd = new MySqlCommand(str_command , conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    string[] frase = new string[1];
                    while (dataReader.Read())
                    {
                        frase[0] = dataReader["id"]+"-"+dataReader["idClienteAgendado"]+"-"+dataReader["data"]+"-"+dataReader["horario"]+"-"+dataReader["ids_ServicosAgendados"]+"-"+dataReader["valorTotal"];
                    }

                    string[] palavras = frase[0].Split('-');
                    //palavras[4] = id dos servicos agendados 

                    agendado.Id = int.Parse(palavras[0]);
                    idClienteAgendadoA = int.Parse(palavras[1]);
                    agendado.Data = palavras[2].Remove(palavras[2].Length - 9);
                    agendado.Hora = palavras[3];
                    agendado.ValorTotal = double.Parse(palavras[5]);

                    string[] ids = palavras[4].Split(',');
                    foreach (string idTemp in ids)
                    {
                        servicosAgendados.Add(int.Parse(idTemp));
                    }
                }
                dataReader.Close();

                str_command =
                    "SELECT * FROM clientes WHERE id="+idClienteAgendadoA+";";
                cmd = new MySqlCommand(str_command , conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    string[] frase = new string[1];
                    while (dataReader.Read())
                    {
                        frase[0] = dataReader["id"] + "-" + dataReader["nome"] ;
                    }

                    string[] infos = frase[0].Split('-');

                    infos = frase[0].Split('-');

                    agendado.ClienteAgendado = infos[1];
                }
                dataReader.Close();

                str_command =
                    "SELECT * FROM servicos;";
                cmd = new MySqlCommand(str_command , conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                   
                    while (dataReader.Read())
                    {
                        servicos.Add(new Servico(int.Parse(dataReader["id"].ToString()) , dataReader["nome"].ToString() , double.Parse(dataReader["valor"].ToString())));
                    }

                }
                dataReader.Close();

                foreach (int numero in servicosAgendados)
                {
                    foreach (Servico sTemp in servicos)
                    {
                        if (sTemp.Id == numero)
                        {
                            agendado.Servs.Add(sTemp);
                        }
                    }
                }

                EditFormAgendamento agendForm = new EditFormAgendamento(agendado);
                agendForm.Show();

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);

            } finally
            {
                conn.Close();
            }



            

        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;
            List<Agendamento> agendamentosQuery = new List<Agendamento>();
            List<Servico> servicosLista = new List<Servico>();

            try
            {
                conn.Open();

                str_command =
                    "SELECT * FROM servicos";
                cmd = new MySqlCommand(str_command, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        servicosLista.Add(new Servico(int.Parse(dataReader["id"].ToString()) , dataReader["nome"].ToString() , double.Parse(dataReader["valor"].ToString())));
                    }

                   
                }

                dataReader.Close();

                str_command =
                    "SELECT agendamentos.id , clientes.nome , agendamentos.data , agendamentos.horario , agendamentos.ids_ServicosAgendados , agendamentos.valorTotal " +
                    "FROM agendamentos , clientes " +
                    "WHERE agendamentos.idClienteAgendado = clientes.id AND clientes.nome LIKE '%"+txtbox_nomeCliente.Text+"%';";

                cmd = new MySqlCommand(str_command , conn);
                dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    List<string> lista = new List<string>();
                    while (dataReader.Read())
                    {

                        lista.Add(dataReader["id"]+"-"+dataReader["nome"]+"-"+dataReader["data"].ToString().TrimEnd(new char[] { '0', '0', '0', '0', '0', '0', ':', ':', ':' }) + "-"+dataReader["horario"]+"-"+dataReader["ids_ServicosAgendados"]+"-"+dataReader["valorTotal"]);

                    }

                    foreach (string frase in lista)
                    {
                        string[] palavras = frase.Split('-');
                        Agendamento agendTemp = new Agendamento();
                        agendTemp.Id = int.Parse(palavras[0]);
                        agendTemp.ClienteAgendado = palavras[1];
                        agendTemp.Data =palavras[2];
                        agendTemp.Hora = palavras[3];
                        agendTemp.ValorTotal = double.Parse(palavras[5]);


                        List<int> idsServicos = new List<int>();

                        string[] ids = palavras[4].Split(',');

                        foreach (string id in ids)
                        {
                            idsServicos.Add(int.Parse(id));
                        }

                        foreach (int id in idsServicos)
                        {
                            for (int i=0;i<servicosLista.Count;i++)
                            {
                                if (id == servicosLista[i].Id)
                                {
                                    agendTemp.Servs.Add(servicosLista[i]); ;
                                }
                            }              
                        }

                        agendamentosQuery.Add(agendTemp);
                    }
                }
                dataReader.Close();
                dataGridView1.DataSource = agendamentosQuery;

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);
            } finally
            {
                conn.Close();
            }



        }
    }
}
