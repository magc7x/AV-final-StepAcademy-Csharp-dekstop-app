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
    public partial class EditFormServico : Form
    {
        private Servico s;
        private bool alterarNome = false;
        private bool alterarValor = false;

        public EditFormServico(Servico s)
        {
            InitializeComponent();
            this.s = s;
            lbl_NomeServico.Text = s.Nome;
            lbl_valorServico.Text = "R$ " + s.Valor.ToString();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                if (e.KeyChar != 46)
                {
                    e.Handled = true;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_editarNome_Click(object sender, EventArgs e)
        {
            if (alterarNome)
            {
                lbl_novoNome.Visible = false;
                txtbox_novoNome.Visible = false;
                alterarNome = false;

            } else
            {
                lbl_novoNome.Visible = true;
                txtbox_novoNome.Visible = true;
                alterarNome = true;
            }
        }

        private void btn_editarValor_Click(object sender, EventArgs e)
        {
            if (alterarValor)
            {
                lbl_RS.Visible = false;
                lbl_novoValor.Visible = false;
                lbl_RS.Visible = false;
                txtbox_NovoValor.Visible = false;
                alterarValor = false;
            } else
            {
                lbl_RS.Visible = true;
                lbl_novoValor.Visible = true;
                lbl_RS.Visible = true;
                txtbox_NovoValor.Visible = true;
                alterarValor = true;
            }
        }

        
        private void txtbox_NovoValor_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_novoNome.Text.Length > 1 || txtbox_NovoValor.Text.Length >= 1)
            {
                btn_confirm.Visible = true;
            }
            else
            {
                btn_confirm.Visible = true;
            }
        }

        private void txtbox_novoNome_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_novoNome.Text.Length > 1 || txtbox_NovoValor.Text.Length >= 1)
            {
                btn_confirm.Visible = true;
            }
            else
            {
                btn_confirm.Visible = true;
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            db_conn db = new db_conn();
            MySqlConnection conn = db.getConn();
            MySqlCommand cmd;
            string str_command;
        
            try
            {
                conn.Open();

                if (alterarNome && !alterarValor)
                {
                    bool existe = false;

                    str_command = "SELECT * FROM servicos " +
                        "WHERE nome='"+txtbox_novoNome.Text+"';";
                    cmd = new MySqlCommand( str_command , conn );
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        existe = true;
                    }

                    dataReader.Close();

                    if (existe == false)
                    {
                        str_command =
                            "UPDATE servicos " +
                            "SET nome='" + txtbox_novoNome.Text + "' " +
                            "WHERE id=" + this.s.Id + ";";
                        cmd = new MySqlCommand(str_command, conn);
                        cmd.ExecuteNonQuery();
                        Cadastrado cForm = new Cadastrado(" Valores Modificados");
                        cForm.Show();
                    } else
                    {
                        Cadastrado cForm = new Cadastrado("Já Existe um Serviço com esse nome");
                        cForm.Show();
                    }
                }

                if (alterarValor && !alterarNome)
                {
                    str_command =
                        "UPDATE servicos " +
                        "SET valor=" + txtbox_NovoValor.Text + " " +
                        "WHERE id=" + this.s.Id + ";";
                    cmd = new MySqlCommand(str_command, conn);
                    cmd.ExecuteNonQuery();
                    Cadastrado cForm = new Cadastrado(" Valores Modificados");
                    cForm.Show();
                }

                if (alterarNome && alterarValor)
                {
                    bool existe = false;

                    str_command = "SELECT * FROM servicos " +
                        "WHERE nome='" + txtbox_novoNome.Text + "';";
                    cmd = new MySqlCommand(str_command, conn);
                    MySqlDataReader dataReader = cmd.ExecuteReader();
                    if (dataReader.HasRows)
                    {
                        existe = true;
                    }

                    dataReader.Close();

                    if (existe == false)
                    {
                        str_command =
                            "UPDATE servicos " +
                            "SET nome='" + txtbox_novoNome.Text + "', " +
                            "valor=" + txtbox_NovoValor.Text +
                            " WHERE id=" + this.s.Id + ";";
                        cmd = new MySqlCommand(str_command, conn);
                        cmd.ExecuteNonQuery();
                        Cadastrado cForm = new Cadastrado(" Valores Modificados");
                        cForm.Show();
                    } else
                    {
                        Cadastrado cForm = new Cadastrado("Já Existe um Serviço com esse nome");
                        cForm.Show();
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);

            } finally
            {
                conn.Close();
                this.Close();
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
                    "DELETE FROM servicos WHERE id="+this.s.Id+";";
                cmd = new MySqlCommand(str_command , conn);
                cmd.ExecuteNonQuery();
                Cadastrado clForm = new Cadastrado("   Serviço Excluído com Sucesso");
                clForm.Show();

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);
            } finally
            {
                conn.Close();
                this.Close();
                
            }

        }
    }
}
