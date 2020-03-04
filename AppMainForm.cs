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
    public partial class AppMainForm : Form
    {
        public AppMainForm()
        {        
            InitializeComponent();
        }

        private void AppMainForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastroCliente_Click(object sender, EventArgs e)
        {
            //if true
            if ( home.Visible ) home.Visible = false;
            if ( registroServico.Visible ) registroServico.Visible = false;
            if ( marcarAtendimento.Visible ) marcarAtendimento.Visible = false;
            if (checagemClientes.Visible) checagemClientes.Visible = false;
            if (checarServicos.Visible) checarServicos.Visible = false;
            if (checarAgendamentos.Visible) checarAgendamentos.Visible = false;


            //if false
            if ( !cadastroCliente.Visible )
            {
                cadastroCliente.Visible = true;
                lbl_listaClientes.Visible = false;
                lbl_indicacao.Text = "Cadastro de Cliente";
            }
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            //if true
            if ( cadastroCliente.Visible ) cadastroCliente.Visible = false;
            if ( registroServico.Visible ) registroServico.Visible = false;
            if ( marcarAtendimento.Visible ) marcarAtendimento.Visible = false;
            if (checagemClientes.Visible) checagemClientes.Visible = false;
            if (checarServicos.Visible) checarServicos.Visible = false;
            if (checarAgendamentos.Visible) checarAgendamentos.Visible = false;


            //if false
            if (!home.Visible)
            {
                home.Visible = true;
                lbl_indicacao.Text = "Home";
                lbl_listaClientes.Visible = false;
            }
        }

        private void btn_RegistrarServico_Click(object sender, EventArgs e)
        {
            //if true
            if ( home.Visible ) home.Visible = false;
            if ( cadastroCliente.Visible ) cadastroCliente.Visible = false;
            if ( marcarAtendimento.Visible ) marcarAtendimento.Visible = false;
            if (checagemClientes.Visible) checagemClientes.Visible = false;
            if (checarServicos.Visible) checarServicos.Visible = false;
            if (checarAgendamentos.Visible) checarAgendamentos.Visible = false;


            //if false
            if (!registroServico.Visible)
            {
                registroServico.Visible = true;
                lbl_listaClientes.Visible = false;
                lbl_indicacao.Text = "Cadastro de Serviço";
            }
        }

        private void btn_MarcarAtendimento_Click(object sender, EventArgs e)
        {
            //if true
            if ( home.Visible ) home.Visible = false;
            if ( cadastroCliente.Visible ) cadastroCliente.Visible = false;
            if ( registroServico.Visible ) registroServico.Visible = false;
            if ( checagemClientes.Visible ) checagemClientes.Visible = false;
            if (checarServicos.Visible) checarServicos.Visible = false;
            if (checarAgendamentos.Visible) checarAgendamentos.Visible = false;

            //if false
            if ( !marcarAtendimento.Visible )
            {
                marcarAtendimento.Visible = true;
                lbl_listaClientes.Visible = false;
                lbl_indicacao.Text = "Agendar Atendimento";
            }
        }

        private void btn_ChecarClientes_Click(object sender, EventArgs e)
        {
            //if true
            if ( home.Visible ) home.Visible = false;
            if ( cadastroCliente.Visible ) cadastroCliente.Visible = false;
            if ( registroServico.Visible ) registroServico.Visible = false;
            if ( marcarAtendimento.Visible ) marcarAtendimento.Visible = false;
            if ( checarServicos.Visible ) checarServicos.Visible = false;
            if (checarAgendamentos.Visible) checarAgendamentos.Visible = false;


            //if false
            if ( !checagemClientes.Visible )
            {            
                checagemClientes.Visible = true;
                lbl_listaClientes.Text = "Lista de Clientes";
                lbl_indicacao.Text = "Clientes Cadastrados";

                if (!lbl_listaClientes.Visible) lbl_listaClientes.Visible = true;
            }

        }

        private void btn_checarServicosRegistrados_Click(object sender, EventArgs e)
        {
            //if true
            if (home.Visible) home.Visible = false;
            if (cadastroCliente.Visible) cadastroCliente.Visible = false;
            if (registroServico.Visible) registroServico.Visible = false;
            if (marcarAtendimento.Visible) marcarAtendimento.Visible = false;
            if (checagemClientes.Visible) checagemClientes.Visible = false;
            if (checarAgendamentos.Visible) checarAgendamentos.Visible = false;


            //if false
            if ( !checarServicos.Visible )
            {              
                checarServicos.Visible = true;
                lbl_listaClientes.Text = "Lista de Serviços";
                lbl_indicacao.Text = "Serviços Cadastrados";

                if (!lbl_listaClientes.Visible) lbl_listaClientes.Visible = true;
            }

        }

        private void btn_ChecarAtendimentos_Click(object sender, EventArgs e)
        {
            //if true
            if (home.Visible) home.Visible = false;
            if (cadastroCliente.Visible) cadastroCliente.Visible = false;
            if (registroServico.Visible) registroServico.Visible = false;
            if (marcarAtendimento.Visible) marcarAtendimento.Visible = false;
            if (checagemClientes.Visible) checagemClientes.Visible = false;
            if (checarServicos.Visible) checarServicos.Visible = false;


            //if false
            if ( !checarAgendamentos.Visible )
            {                
                checarAgendamentos.Visible = true;
                lbl_listaClientes.Text = "Lista de Agendamentos";
                lbl_indicacao.Text = "Agendamentos Cadastrados";

                if (!lbl_listaClientes.Visible) lbl_listaClientes.Visible = true;
            }

        }
    }
}
