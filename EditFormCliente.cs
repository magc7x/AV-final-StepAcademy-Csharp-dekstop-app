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
    public partial class EditFormCliente : Form
    {
        private Cliente c;
        private bool alterarEmail = false;
        private bool alterarTelefone = false;

        public EditFormCliente(Cliente c)
        {
            InitializeComponent();
            this.c = c;
            lbl_NomeCliente.Text = c.Nome;
            lbl_sexoCliente.Text = c.Sexo.ToString();
            lbl_telefone.Text = c.Telefone;
            lbl_cpf.Text = c.Cpf;
            lbl_email.Text = c.Email;        
            lbl_nasc.Text = c.Nasc;
            
            
            
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

                if (alterarEmail && !alterarTelefone)
                {
                    str_command =
                        "UPDATE clientes " +
                        "SET email='"+txtbox_novoEmail.Text+"'  " +
                        "WHERE id="+this.c.Id+" ;";

                    cmd = new MySqlCommand( str_command , conn);
                    cmd.ExecuteNonQuery();
                    Cadastrado cForm = new Cadastrado("Informação Modificada");
                    cForm.Show();
                }

                if (alterarTelefone && !alterarEmail)
                {
                    str_command =
                        "UPDATE clientes " +
                        "SET telefone='" + txtxbox_novoNumero.Text + "'  " +
                        "WHERE id=" + this.c.Id + " ;";

                    cmd = new MySqlCommand(str_command, conn);
                    cmd.ExecuteNonQuery();
                    Cadastrado cForm = new Cadastrado("Informação Modificada");
                    cForm.Show();
                }

                if (alterarEmail && alterarTelefone)
                {

                    str_command = 
                        "UPDATE clientes "+
                        "SET telefone='"+txtxbox_novoNumero.Text + "' , " +
                        "email='"+txtbox_novoEmail.Text+"' " +
                        "WHERE id="+ this.c.Id+";";

                    cmd = new MySqlCommand(str_command, conn);
                    cmd.ExecuteNonQuery();
                    Cadastrado cForm = new Cadastrado("Informações Modificadas");
                    cForm.Show();
                }

            } catch (Exception ex)
            {
                MessageBox.Show("ERRO " + ex.Message);

            } finally
            {
                conn.Close();
                btn_confirm.Visible = false;
                txtbox_novoEmail.Text = null;
                txtbox_novoEmail.Visible = false;
                txtxbox_novoNumero.Text = null;
                txtxbox_novoNumero.Visible = false;
                lbl_novoEmail.Visible = false;
                lbl_novoNumero.Visible = false;
                this.Close();

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btn_editarTelefone_Click(object sender, EventArgs e)
        {
            if (!lbl_novoNumero.Visible)
            {
                lbl_novoNumero.Visible = true;
                txtxbox_novoNumero.Visible = true;
                this.alterarTelefone = true;
            } else
            {
                lbl_novoNumero.Visible = false;
                txtxbox_novoNumero.Visible = false;
                this.alterarTelefone = false;
            }        
        }

        private void btn_editarEmail_Click(object sender, EventArgs e)
        {
            if (!lbl_novoEmail.Visible )
            {
                lbl_novoEmail.Visible = true;
                txtbox_novoEmail.Visible = true;
                this.alterarEmail = true;
            } else
            {
                lbl_novoEmail.Visible = false;
                txtbox_novoEmail.Visible = false;
                this.alterarEmail = false;
            }
        }

        private void txtxbox_novoNumero_TextChanged(object sender, EventArgs e)
        {
            if (txtxbox_novoNumero.Text.Length > 0 || txtbox_novoEmail.Text.Length > 0)
            {
                btn_confirm.Visible = true;
            } else
            {
                btn_confirm.Visible = false;
            }
        }

        private void txtbox_novoEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtbox_novoEmail.Text.Length > 0 || txtxbox_novoNumero.Text.Length > 0)
            {
                btn_confirm.Visible = true;
            }
            else
            {
                btn_confirm.Visible = false;
            }
        }

        private void lbl_sexoCliente_Click(object sender, EventArgs e)
        {

        }

        private void EditFormCliente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
