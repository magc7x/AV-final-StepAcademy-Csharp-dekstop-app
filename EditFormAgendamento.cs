using AVfinal.DB;
using AVfinal.entities;
using AVfinal.util_forms;
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

namespace AVfinal
{
    public partial class EditFormAgendamento : Form
    {
        private  Agendamento agend;
        private BindingList<Servico> bListServs = new BindingList<Servico>();
        private double valorTotal;

        private bool editarCliente = false;
        private bool editarHora = false;
        private bool editarData = false;
        private bool editarServicos = false;


        public EditFormAgendamento(Agendamento agend)
        {
            InitializeComponent();
            this.agend = agend;
            lbl_NomeCliente.Text = agend.ClienteAgendado;
            lbl_dataAgendamento.Text = agend.Data;
            lbl_hora.Text = agend.Hora;
            dataGridView1.DataSource = agend.Servs;
            lbl_valorTotal.Text = agend.ValorTotal.ToString();
            carregaServs();
            valorTotal = agend.ValorTotal;
        }

        private void carregaServs()
        {
            bListServs = new BindingList<Servico>();
            foreach (Servico s in agend.Servs)
            {
                bListServs.Add(s);
            }
        }

        private void loadAdicionarServicosTrue()
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;
            List<Servico> servicosToAdd = new List<Servico>();

            try
            {
                conn.Open();

                str_command =
                    "SELECT * FROM servicos;";
                cmd = new MySqlCommand(str_command , conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();

                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        servicosToAdd.Add(new Servico(int.Parse(dataReader["id"].ToString()) , dataReader["nome"].ToString() , double.Parse(dataReader["valor"].ToString())));
                    }
                }
                dataReader.Close();
                dataGridView2.DataSource = servicosToAdd;

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO "+ ex.Message);
            } finally
            {
                conn.Close();
            }

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
                cmd = new MySqlCommand(str_command, conn);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                List<Cliente> listClientes = new List<Cliente>();

                if (dataReader.HasRows)
                {
                    List<string> lista = new List<string>();
                    while (dataReader.Read())
                    {
                        lista.Add(dataReader["id"] + "-" + dataReader["nome"] + "-" + dataReader["sexo"] + "-" + dataReader["telefone"] + "-" + dataReader["email"] + "-" + dataReader["nasc"] + "-" + dataReader["cpf"]);
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
                    combobox_cliente.Items.Add(c.Id + " - " + c.Nome);
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


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditFormAgendamento_Load(object sender, EventArgs e)
        {
            loadComboBoxClientes();
        }

        private void btn_editarClienteAgendado_Click(object sender, EventArgs e)
        {
            if (editarCliente == false)
            {
                lbl_novoClienteAgendado.Visible = true;
                combobox_cliente.Visible = true;
                editarCliente = true;
            } else
            {
                lbl_novoClienteAgendado.Visible = false;
                combobox_cliente.Visible = false;
                combobox_cliente.Text = null;
                editarCliente = false;
            }

            if (editarCliente == false && editarData == false && editarHora == false && editarServicos == false)
            {
                btn_confirm.Visible = false;
            }

        }

        private void btn_editarData_Click(object sender, EventArgs e)
        {
            if (editarData == false)
            {
                lbl_novaData.Visible = true;
                dateTime_novaData.Visible = true;
                editarData = true;

                //if (editarCliente == true && editarData == true) {
                    //if (combobox_cliente.Text.Length > 3) {
                        //btn_confirm.Visible = true;
                    //}
                //} else
                //{
                    btn_confirm.Visible = true;
                //}
            }
            else
            {
                lbl_novaData.Visible = false;
                dateTime_novaData.Visible = false;
                editarData = false;
            }

            if (editarCliente == false && editarData == false && editarHora == false && editarServicos == false)
            {
                btn_confirm.Visible = false;
            }

        }

        private void btn_editarHora_Click(object sender, EventArgs e)
        {
            if (editarHora == false)
            {
                lbl_novaHora.Visible = true;
                comboBox_novoHorario.Visible = true;
                editarHora = true;
            }
            else
            {
                lbl_novaHora.Visible = false;
                comboBox_novoHorario.Visible = false;
                editarHora = false;
                comboBox_novoHorario.Text = null;
            }

            if (editarCliente == false && editarData == false && editarHora == false && editarServicos == false)
            {
                btn_confirm.Visible = false;
            }

        }

        private void btn_editarServicos_Click(object sender, EventArgs e)
        {
            if (editarServicos == false)
            {
                lbl_adicionarServicos.Visible = true;
                dataGridView2.Visible = true;
                btn_addServico.Visible = true;
                btn_removeServicos.Visible = true;
                lbl_removeServicos.Visible = true;
                dataGridView3.Visible = true;
                lbl_valorTotalText.Visible = true;
                lbl_rsNovoValorTotal.Visible = true;
                lbl_novoValorTotal.Visible = true;
                editarServicos = true;
                lbl_valorTotalText.Text = agend.ValorTotal.ToString();
                loadAdicionarServicosTrue();
                carregaServs();
                btn_confirm.Visible = true;
                lbl_valorTotalText.Text = agend.ValorTotal.ToString();
                dataGridView3.DataSource = bListServs;
                valorTotal = agend.ValorTotal;
            }
            else
            {
                lbl_adicionarServicos.Visible = false;
                dataGridView2.Visible = false;
                btn_addServico.Visible = false;
                btn_removeServicos.Visible = false;
                lbl_removeServicos.Visible = false;
                dataGridView3.Visible = false;
                lbl_valorTotalText.Visible = false;
                lbl_rsNovoValorTotal.Visible = false;
                lbl_novoValorTotal.Visible = false;
                editarServicos = false;
            }

            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;


            try
            {
                conn.Open();

                str_command =
                    "DELETE FROM agendamentos WHERE id="+this.agend.Id+";";
                cmd = new MySqlCommand(str_command , conn);
                cmd.ExecuteNonQuery();

                Cadastrado clForm = new Cadastrado("Agendamento Desmarcado");
                clForm.Show();

                this.Close();    

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);
            } finally
            {
                conn.Close();
            }

        }

        private void combobox_cliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void combobox_cliente_TextChanged(object sender, EventArgs e)
        {
            

            if (editarCliente == true && editarData == false && editarHora == false && editarServicos == false)
            {
                btn_confirm.Visible = true;

            } else if (editarCliente == true && editarHora == true)
            {
                if (combobox_cliente.Text.Length > 3 && comboBox_novoHorario.Text.Length > 3)
                {
                    btn_confirm.Visible = true;
                }
            } else
            {
                btn_confirm.Visible = false;
            } 
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            if (editarHora == true && editarCliente == false && editarData == false && editarServicos == false)
            {
                if (comboBox_novoHorario.Text.Length > 3) 
                {
                    btn_confirm.Visible = true;
                }
            }
        }

        private void btn_addServico_Click(object sender, EventArgs e)
        {
            Servico sTemp = new Servico();
            sTemp.Id = (int) dataGridView2.CurrentRow.Cells[0].Value;
            sTemp.Nome = (string)dataGridView2.CurrentRow.Cells[1].Value;
            sTemp.Valor = (double)dataGridView2.CurrentRow.Cells[2].Value;
            bListServs.Add(sTemp);

            valorTotal += sTemp.Valor;
            lbl_valorTotalText.Text = valorTotal.ToString();
            dataGridView3.DataSource = bListServs;
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;
            bool[] editados = new bool[] { false, false, false, false };
            //0 = servicos , 1=cliente , 2=hora , 3=data

            if (editarServicos == true)
            {
                try
                {
                    conn.Open();

                    string ids = bListServs[0].Id.ToString();

                    for (int i=0; i< bListServs.Count; i++)
                    {
                        if (i > 0)
                        {
                            ids += "," + bListServs[i].Id.ToString();
                        }
                    }


                    str_command = 
                        "UPDATE agendamentos " +
                        "SET ids_ServicosAgendados='"+ids+"', valorTotal="+lbl_valorTotalText.Text+" " +
                        "WHERE id="+agend.Id+";";
                    cmd = new MySqlCommand(str_command , conn);
                    cmd.ExecuteNonQuery();

                    editados[0] = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERRO " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    lbl_adicionarServicos.Visible = false;
                    dataGridView2.Visible = false;
                    btn_addServico.Visible = false;
                    btn_removeServicos.Visible = false;
                    lbl_removeServicos.Visible = false;
                    dataGridView3.Visible = false;
                    lbl_valorTotalText.Visible = false;
                    lbl_rsNovoValorTotal.Visible = false;
                    lbl_novoValorTotal.Visible = false;
                    editarServicos = false;
                }

            }

            if (editarCliente == true)
            {
                try
                {
                    conn.Open();

                    if (combobox_cliente.Text.Length > 2)
                    {
                        string[] splitName = combobox_cliente.Text.Split('-');

                        str_command =
                            "UPDATE agendamentos " +
                            "SET idClienteAgendado=" + splitName[0] + " " +
                            "WHERE id=" + agend.Id + ";";
                        cmd = new MySqlCommand(str_command, conn);
                        cmd.ExecuteNonQuery();

                        editados[1] = true;
                    } else
                    {
                        Cadastrado clForm = new Cadastrado("Não Houve Alteração no cliente agendado");
                        clForm.Show();
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show("ERRO " + ex.Message);
                } finally
                {
                    conn.Close();
                    lbl_novoClienteAgendado.Visible = false;
                    combobox_cliente.Visible = false;
                    combobox_cliente.Text = null;
                    editarCliente = false;
                }

            }

            if (editarHora == true)
            {
                try
                {
                    conn.Open();

                    if (comboBox_novoHorario.Text.Length > 2) {
                        str_command =
                            "UPDATE agendamentos " +
                            "SET horario='" + comboBox_novoHorario.Text + "' " +
                            "WHERE id="+agend.Id+";";
                        cmd = new MySqlCommand(str_command , conn);
                        cmd.ExecuteNonQuery();

                        editados[2] = true;
                    } else
                    {
                        Cadastrado clForm = new Cadastrado("Não houve alteração no Horário");
                        clForm.Show();
                    }

                } catch (Exception ex)
                {
                    MessageBox.Show("ERRO " + ex.Message);
                }finally
                {
                    conn.Close();
                    lbl_novaHora.Visible = false;
                    comboBox_novoHorario.Visible = false;
                    editarHora = false;
                    comboBox_novoHorario.Text = null;
                }
            }

            if (editarData == true)
            {
                try
                {
                    conn.Open();

                    str_command =
                        "UPDATE agendamentos " +
                        "SET data='" + dateTime_novaData.Text + "' " +
                        "WHERE id=" + agend.Id+";" ;
                    cmd = new MySqlCommand(str_command , conn);
                    cmd.ExecuteNonQuery();

                    editados[3] = true;

                } catch (Exception ex)
                {
                    MessageBox.Show("ERRO "+ ex.Message);
                } finally
                {
                    conn.Close();
                    lbl_novaData.Visible = false;
                    dateTime_novaData.Visible = false;
                    editarData = false;
                }

            }

            //0 = servicos , 1=cliente , 2=hora , 3=data
            if (editados[0] == true)
            {
                Cadastrado cadastrado = new Cadastrado("Serviços Alterados!");
                cadastrado.Show();
            }

            if (editados[1] == true)
            {
                Cadastrado cadastrado = new Cadastrado("Cliente Agendado Alterado!");
                cadastrado.Show();
            }

            if (editados[2] == true)
            {
                Cadastrado cadastrado = new Cadastrado("Horário Alterado!");
                cadastrado.Show();
            }

            if (editados[3] == true)
            {
                Cadastrado cadastrado = new Cadastrado("Data Alterada!");
                cadastrado.Show();
            }

            this.Close();
        }


        private void btn_removeServicos_Click(object sender, EventArgs e)
        {
            int index = dataGridView3.Rows.Count;
            if (index > 1)
            {                
                valorTotal -= (double)dataGridView3.CurrentRow.Cells[2].Value;
                dataGridView3.Rows.RemoveAt(dataGridView3.CurrentRow.Index);
                lbl_valorTotalText.Text = valorTotal.ToString();               
            }
        }
    }
}
