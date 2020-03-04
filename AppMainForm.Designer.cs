namespace AVfinal
{
    partial class AppMainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppMainForm));
            this.panel_navegacao = new System.Windows.Forms.Panel();
            this.btn_checarServicosRegistrados = new System.Windows.Forms.Button();
            this.btn_RegistrarServico = new System.Windows.Forms.Button();
            this.btn_ChecarClientes = new System.Windows.Forms.Button();
            this.btn_ChecarAtendimentos = new System.Windows.Forms.Button();
            this.btn_MarcarAtendimento = new System.Windows.Forms.Button();
            this.btn_cadastroCliente = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.panel_top = new System.Windows.Forms.Panel();
            this.lbl_listaClientes = new System.Windows.Forms.Label();
            this.lbl_indicacao = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checarServicos = new AVfinal.user_Controls.checarServicos();
            this.checagemClientes = new AVfinal.user_Controls.checagemClientes();
            this.marcarAtendimento = new AVfinal.user_Controls.marcarAtendimento();
            this.registroServico = new AVfinal.user_Controls.registroServico();
            this.cadastroCliente = new AVfinal.user_Controls.cadastroCliente();
            this.home = new AVfinal.user_Controls.home();
            this.checarAgendamentos = new AVfinal.user_Controls.checarAgendamentos();
            this.panel_navegacao.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_navegacao
            // 
            this.panel_navegacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.panel_navegacao.Controls.Add(this.btn_checarServicosRegistrados);
            this.panel_navegacao.Controls.Add(this.btn_RegistrarServico);
            this.panel_navegacao.Controls.Add(this.btn_ChecarClientes);
            this.panel_navegacao.Controls.Add(this.btn_ChecarAtendimentos);
            this.panel_navegacao.Controls.Add(this.btn_MarcarAtendimento);
            this.panel_navegacao.Controls.Add(this.btn_cadastroCliente);
            this.panel_navegacao.Controls.Add(this.btn_home);
            this.panel_navegacao.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_navegacao.Location = new System.Drawing.Point(0, 0);
            this.panel_navegacao.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.panel_navegacao.Name = "panel_navegacao";
            this.panel_navegacao.Size = new System.Drawing.Size(321, 697);
            this.panel_navegacao.TabIndex = 0;
            // 
            // btn_checarServicosRegistrados
            // 
            this.btn_checarServicosRegistrados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_checarServicosRegistrados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_checarServicosRegistrados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_checarServicosRegistrados.FlatAppearance.BorderSize = 0;
            this.btn_checarServicosRegistrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_checarServicosRegistrados.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checarServicosRegistrados.ForeColor = System.Drawing.Color.White;
            this.btn_checarServicosRegistrados.Image = ((System.Drawing.Image)(resources.GetObject("btn_checarServicosRegistrados.Image")));
            this.btn_checarServicosRegistrados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_checarServicosRegistrados.Location = new System.Drawing.Point(3, 201);
            this.btn_checarServicosRegistrados.Name = "btn_checarServicosRegistrados";
            this.btn_checarServicosRegistrados.Size = new System.Drawing.Size(315, 60);
            this.btn_checarServicosRegistrados.TabIndex = 7;
            this.btn_checarServicosRegistrados.Text = "  Checar Serviços Cadastros";
            this.btn_checarServicosRegistrados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_checarServicosRegistrados.UseVisualStyleBackColor = false;
            this.btn_checarServicosRegistrados.Click += new System.EventHandler(this.btn_checarServicosRegistrados_Click);
            // 
            // btn_RegistrarServico
            // 
            this.btn_RegistrarServico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_RegistrarServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_RegistrarServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RegistrarServico.FlatAppearance.BorderSize = 0;
            this.btn_RegistrarServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_RegistrarServico.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RegistrarServico.ForeColor = System.Drawing.Color.White;
            this.btn_RegistrarServico.Image = ((System.Drawing.Image)(resources.GetObject("btn_RegistrarServico.Image")));
            this.btn_RegistrarServico.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_RegistrarServico.Location = new System.Drawing.Point(3, 333);
            this.btn_RegistrarServico.Name = "btn_RegistrarServico";
            this.btn_RegistrarServico.Size = new System.Drawing.Size(315, 60);
            this.btn_RegistrarServico.TabIndex = 6;
            this.btn_RegistrarServico.Text = "  Cadastrar Serviço";
            this.btn_RegistrarServico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_RegistrarServico.UseVisualStyleBackColor = false;
            this.btn_RegistrarServico.Click += new System.EventHandler(this.btn_RegistrarServico_Click);
            // 
            // btn_ChecarClientes
            // 
            this.btn_ChecarClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_ChecarClientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ChecarClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChecarClientes.FlatAppearance.BorderSize = 0;
            this.btn_ChecarClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChecarClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChecarClientes.ForeColor = System.Drawing.Color.White;
            this.btn_ChecarClientes.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChecarClientes.Image")));
            this.btn_ChecarClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChecarClientes.Location = new System.Drawing.Point(3, 135);
            this.btn_ChecarClientes.Name = "btn_ChecarClientes";
            this.btn_ChecarClientes.Size = new System.Drawing.Size(315, 60);
            this.btn_ChecarClientes.TabIndex = 5;
            this.btn_ChecarClientes.Text = "  Checar Clientes Registrados";
            this.btn_ChecarClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChecarClientes.UseVisualStyleBackColor = false;
            this.btn_ChecarClientes.Click += new System.EventHandler(this.btn_ChecarClientes_Click);
            // 
            // btn_ChecarAtendimentos
            // 
            this.btn_ChecarAtendimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_ChecarAtendimentos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ChecarAtendimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ChecarAtendimentos.FlatAppearance.BorderSize = 0;
            this.btn_ChecarAtendimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChecarAtendimentos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ChecarAtendimentos.ForeColor = System.Drawing.Color.White;
            this.btn_ChecarAtendimentos.Image = ((System.Drawing.Image)(resources.GetObject("btn_ChecarAtendimentos.Image")));
            this.btn_ChecarAtendimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ChecarAtendimentos.Location = new System.Drawing.Point(3, 69);
            this.btn_ChecarAtendimentos.Name = "btn_ChecarAtendimentos";
            this.btn_ChecarAtendimentos.Size = new System.Drawing.Size(315, 60);
            this.btn_ChecarAtendimentos.TabIndex = 3;
            this.btn_ChecarAtendimentos.Text = "  Checar Agendamentos";
            this.btn_ChecarAtendimentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ChecarAtendimentos.UseVisualStyleBackColor = false;
            this.btn_ChecarAtendimentos.Click += new System.EventHandler(this.btn_ChecarAtendimentos_Click);
            // 
            // btn_MarcarAtendimento
            // 
            this.btn_MarcarAtendimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_MarcarAtendimento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_MarcarAtendimento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MarcarAtendimento.FlatAppearance.BorderSize = 0;
            this.btn_MarcarAtendimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarcarAtendimento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MarcarAtendimento.ForeColor = System.Drawing.Color.White;
            this.btn_MarcarAtendimento.Image = ((System.Drawing.Image)(resources.GetObject("btn_MarcarAtendimento.Image")));
            this.btn_MarcarAtendimento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MarcarAtendimento.Location = new System.Drawing.Point(3, 399);
            this.btn_MarcarAtendimento.Name = "btn_MarcarAtendimento";
            this.btn_MarcarAtendimento.Size = new System.Drawing.Size(315, 60);
            this.btn_MarcarAtendimento.TabIndex = 2;
            this.btn_MarcarAtendimento.Text = "  Agendar Atendimento";
            this.btn_MarcarAtendimento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_MarcarAtendimento.UseVisualStyleBackColor = false;
            this.btn_MarcarAtendimento.Click += new System.EventHandler(this.btn_MarcarAtendimento_Click);
            // 
            // btn_cadastroCliente
            // 
            this.btn_cadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_cadastroCliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cadastroCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastroCliente.FlatAppearance.BorderSize = 0;
            this.btn_cadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastroCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastroCliente.ForeColor = System.Drawing.Color.White;
            this.btn_cadastroCliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_cadastroCliente.Image")));
            this.btn_cadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cadastroCliente.Location = new System.Drawing.Point(3, 267);
            this.btn_cadastroCliente.Name = "btn_cadastroCliente";
            this.btn_cadastroCliente.Size = new System.Drawing.Size(315, 60);
            this.btn_cadastroCliente.TabIndex = 1;
            this.btn_cadastroCliente.Text = "  Cadastrar Cliente";
            this.btn_cadastroCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cadastroCliente.UseVisualStyleBackColor = false;
            this.btn_cadastroCliente.Click += new System.EventHandler(this.btn_cadastroCliente_Click);
            // 
            // btn_home
            // 
            this.btn_home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.FlatAppearance.BorderSize = 0;
            this.btn_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_home.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_home.ForeColor = System.Drawing.Color.White;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_home.Location = new System.Drawing.Point(3, 3);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(315, 60);
            this.btn_home.TabIndex = 0;
            this.btn_home.Text = "  Home";
            this.btn_home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_home.UseVisualStyleBackColor = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.White;
            this.panel_top.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel_top.Controls.Add(this.lbl_listaClientes);
            this.panel_top.Controls.Add(this.lbl_indicacao);
            this.panel_top.Controls.Add(this.pictureBox1);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(321, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(963, 73);
            this.panel_top.TabIndex = 1;
            // 
            // lbl_listaClientes
            // 
            this.lbl_listaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_listaClientes.AutoSize = true;
            this.lbl_listaClientes.Location = new System.Drawing.Point(670, 45);
            this.lbl_listaClientes.Name = "lbl_listaClientes";
            this.lbl_listaClientes.Size = new System.Drawing.Size(155, 22);
            this.lbl_listaClientes.TabIndex = 5;
            this.lbl_listaClientes.Text = "Lista de Clientes";
            this.lbl_listaClientes.Visible = false;
            // 
            // lbl_indicacao
            // 
            this.lbl_indicacao.AutoSize = true;
            this.lbl_indicacao.Font = new System.Drawing.Font("Century Gothic", 16.25F);
            this.lbl_indicacao.Location = new System.Drawing.Point(73, 19);
            this.lbl_indicacao.Name = "lbl_indicacao";
            this.lbl_indicacao.Size = new System.Drawing.Size(77, 25);
            this.lbl_indicacao.TabIndex = 4;
            this.lbl_indicacao.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // checarServicos
            // 
            this.checarServicos.BackColor = System.Drawing.Color.White;
            this.checarServicos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checarServicos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checarServicos.Location = new System.Drawing.Point(321, 73);
            this.checarServicos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checarServicos.Name = "checarServicos";
            this.checarServicos.Size = new System.Drawing.Size(963, 624);
            this.checarServicos.TabIndex = 7;
            this.checarServicos.Visible = false;
            // 
            // checagemClientes
            // 
            this.checagemClientes.BackColor = System.Drawing.Color.White;
            this.checagemClientes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checagemClientes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checagemClientes.Location = new System.Drawing.Point(321, 73);
            this.checagemClientes.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checagemClientes.Name = "checagemClientes";
            this.checagemClientes.Size = new System.Drawing.Size(963, 624);
            this.checagemClientes.TabIndex = 6;
            this.checagemClientes.Visible = false;
            // 
            // marcarAtendimento
            // 
            this.marcarAtendimento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.marcarAtendimento.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcarAtendimento.Location = new System.Drawing.Point(321, 73);
            this.marcarAtendimento.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.marcarAtendimento.Name = "marcarAtendimento";
            this.marcarAtendimento.Size = new System.Drawing.Size(963, 624);
            this.marcarAtendimento.TabIndex = 5;
            this.marcarAtendimento.Visible = false;
            // 
            // registroServico
            // 
            this.registroServico.BackColor = System.Drawing.Color.White;
            this.registroServico.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registroServico.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroServico.Location = new System.Drawing.Point(321, 73);
            this.registroServico.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.registroServico.Name = "registroServico";
            this.registroServico.Size = new System.Drawing.Size(963, 624);
            this.registroServico.TabIndex = 4;
            this.registroServico.Visible = false;
            // 
            // cadastroCliente
            // 
            this.cadastroCliente.BackColor = System.Drawing.Color.White;
            this.cadastroCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cadastroCliente.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cadastroCliente.Location = new System.Drawing.Point(321, 73);
            this.cadastroCliente.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.cadastroCliente.Name = "cadastroCliente";
            this.cadastroCliente.Size = new System.Drawing.Size(963, 624);
            this.cadastroCliente.TabIndex = 3;
            this.cadastroCliente.Visible = false;
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.White;
            this.home.Dock = System.Windows.Forms.DockStyle.Fill;
            this.home.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.home.Location = new System.Drawing.Point(321, 73);
            this.home.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(963, 624);
            this.home.TabIndex = 2;
            // 
            // checarAgendamentos
            // 
            this.checarAgendamentos.BackColor = System.Drawing.Color.White;
            this.checarAgendamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checarAgendamentos.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checarAgendamentos.Location = new System.Drawing.Point(321, 73);
            this.checarAgendamentos.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checarAgendamentos.Name = "checarAgendamentos";
            this.checarAgendamentos.Size = new System.Drawing.Size(963, 624);
            this.checarAgendamentos.TabIndex = 8;
            this.checarAgendamentos.Visible = false;
            // 
            // AppMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 697);
            this.Controls.Add(this.checarAgendamentos);
            this.Controls.Add(this.checarServicos);
            this.Controls.Add(this.checagemClientes);
            this.Controls.Add(this.marcarAtendimento);
            this.Controls.Add(this.registroServico);
            this.Controls.Add(this.cadastroCliente);
            this.Controls.Add(this.home);
            this.Controls.Add(this.panel_top);
            this.Controls.Add(this.panel_navegacao);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MinimumSize = new System.Drawing.Size(1300, 600);
            this.Name = "AppMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "  MyApplication";
            this.Load += new System.EventHandler(this.AppMainForm_Load);
            this.panel_navegacao.ResumeLayout(false);
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_navegacao;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.Button btn_cadastroCliente;
        private System.Windows.Forms.Button btn_ChecarAtendimentos;
        private System.Windows.Forms.Button btn_MarcarAtendimento;
        private System.Windows.Forms.Button btn_ChecarClientes;
        private System.Windows.Forms.Panel panel_top;
        private user_Controls.home home;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_RegistrarServico;
        private System.Windows.Forms.Button btn_checarServicosRegistrados;
        private user_Controls.cadastroCliente cadastroCliente;
        private user_Controls.registroServico registroServico;
        private user_Controls.marcarAtendimento marcarAtendimento;
        private System.Windows.Forms.Label lbl_indicacao;
        private user_Controls.checagemClientes checagemClientes;
        private System.Windows.Forms.Label lbl_listaClientes;
        private user_Controls.checarServicos checarServicos;
        private user_Controls.checarAgendamentos checarAgendamentos;
    }
}

