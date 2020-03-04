namespace AVfinal.user_Controls
{
    partial class cadastroCliente
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtbox_nomeCompleto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.combobox_sexo = new System.Windows.Forms.ComboBox();
            this.txtbox_cpf = new System.Windows.Forms.TextBox();
            this.txtbox_telefone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbox_email = new System.Windows.Forms.TextBox();
            this.dateTimePicker_aniversario = new System.Windows.Forms.DateTimePicker();
            this.btn_cadastrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbox_nomeCompleto
            // 
            this.txtbox_nomeCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtbox_nomeCompleto.Location = new System.Drawing.Point(77, 86);
            this.txtbox_nomeCompleto.Name = "txtbox_nomeCompleto";
            this.txtbox_nomeCompleto.Size = new System.Drawing.Size(291, 26);
            this.txtbox_nomeCompleto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome Completo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(400, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Telefone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cpf";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Email";
            // 
            // combobox_sexo
            // 
            this.combobox_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.combobox_sexo.FormattingEnabled = true;
            this.combobox_sexo.Items.AddRange(new object[] {
            "M",
            "F"});
            this.combobox_sexo.Location = new System.Drawing.Point(404, 85);
            this.combobox_sexo.MaxLength = 1;
            this.combobox_sexo.Name = "combobox_sexo";
            this.combobox_sexo.Size = new System.Drawing.Size(59, 28);
            this.combobox_sexo.TabIndex = 10;
            this.combobox_sexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_sexo_KeyPress);
            // 
            // txtbox_cpf
            // 
            this.txtbox_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtbox_cpf.Location = new System.Drawing.Point(77, 159);
            this.txtbox_cpf.MaxLength = 11;
            this.txtbox_cpf.Name = "txtbox_cpf";
            this.txtbox_cpf.Size = new System.Drawing.Size(183, 26);
            this.txtbox_cpf.TabIndex = 11;
            this.txtbox_cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_cpf_KeyPress);
            // 
            // txtbox_telefone
            // 
            this.txtbox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtbox_telefone.Location = new System.Drawing.Point(285, 159);
            this.txtbox_telefone.MaxLength = 11;
            this.txtbox_telefone.Name = "txtbox_telefone";
            this.txtbox_telefone.Size = new System.Drawing.Size(178, 26);
            this.txtbox_telefone.TabIndex = 13;
            this.txtbox_telefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbox_telefone_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nascimento";
            // 
            // txtbox_email
            // 
            this.txtbox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtbox_email.Location = new System.Drawing.Point(77, 236);
            this.txtbox_email.Name = "txtbox_email";
            this.txtbox_email.Size = new System.Drawing.Size(291, 26);
            this.txtbox_email.TabIndex = 16;
            // 
            // dateTimePicker_aniversario
            // 
            this.dateTimePicker_aniversario.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker_aniversario.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_aniversario.Location = new System.Drawing.Point(77, 315);
            this.dateTimePicker_aniversario.Name = "dateTimePicker_aniversario";
            this.dateTimePicker_aniversario.Size = new System.Drawing.Size(259, 29);
            this.dateTimePicker_aniversario.TabIndex = 17;
            // 
            // btn_cadastrar
            // 
            this.btn_cadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastrar.Location = new System.Drawing.Point(351, 315);
            this.btn_cadastrar.Name = "btn_cadastrar";
            this.btn_cadastrar.Size = new System.Drawing.Size(112, 31);
            this.btn_cadastrar.TabIndex = 18;
            this.btn_cadastrar.Text = "Cadastrar";
            this.btn_cadastrar.UseVisualStyleBackColor = true;
            this.btn_cadastrar.Click += new System.EventHandler(this.btn_cadastrar_Click);
            // 
            // cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_cadastrar);
            this.Controls.Add(this.dateTimePicker_aniversario);
            this.Controls.Add(this.txtbox_email);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbox_telefone);
            this.Controls.Add(this.txtbox_cpf);
            this.Controls.Add(this.combobox_sexo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbox_nomeCompleto);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "cadastroCliente";
            this.Size = new System.Drawing.Size(735, 522);
            this.Load += new System.EventHandler(this.cadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbox_nomeCompleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox combobox_sexo;
        private System.Windows.Forms.TextBox txtbox_cpf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbox_telefone;
        private System.Windows.Forms.TextBox txtbox_email;
        private System.Windows.Forms.DateTimePicker dateTimePicker_aniversario;
        private System.Windows.Forms.Button btn_cadastrar;
    }
}
