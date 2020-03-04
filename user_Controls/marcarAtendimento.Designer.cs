namespace AVfinal.user_Controls
{
    partial class marcarAtendimento
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
            this.combobox_cliente = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridViewServicos = new System.Windows.Forms.DataGridView();
            this.btn_agendar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_valor = new System.Windows.Forms.Label();
            this.daTime_data = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.combobox_hora = new System.Windows.Forms.ComboBox();
            this.btn_addServ = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_removeServ = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // combobox_cliente
            // 
            this.combobox_cliente.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.combobox_cliente.FormattingEnabled = true;
            this.combobox_cliente.Location = new System.Drawing.Point(77, 86);
            this.combobox_cliente.Name = "combobox_cliente";
            this.combobox_cliente.Size = new System.Drawing.Size(305, 29);
            this.combobox_cliente.TabIndex = 0;
            this.combobox_cliente.TextChanged += new System.EventHandler(this.combobox_cliente_TextChanged);
            this.combobox_cliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_cliente_KeyPress);
            this.combobox_cliente.MouseClick += new System.Windows.Forms.MouseEventHandler(this.combobox_cliente_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Selecione os Serviços";
            // 
            // gridViewServicos
            // 
            this.gridViewServicos.BackgroundColor = System.Drawing.Color.White;
            this.gridViewServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewServicos.Location = new System.Drawing.Point(77, 231);
            this.gridViewServicos.MultiSelect = false;
            this.gridViewServicos.Name = "gridViewServicos";
            this.gridViewServicos.Size = new System.Drawing.Size(365, 163);
            this.gridViewServicos.TabIndex = 9;
            // 
            // btn_agendar
            // 
            this.btn_agendar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_agendar.Location = new System.Drawing.Point(77, 447);
            this.btn_agendar.Name = "btn_agendar";
            this.btn_agendar.Size = new System.Drawing.Size(103, 33);
            this.btn_agendar.TabIndex = 10;
            this.btn_agendar.Text = "Agendar";
            this.btn_agendar.UseVisualStyleBackColor = true;
            this.btn_agendar.Click += new System.EventHandler(this.btn_agendar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "Valor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 422);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "R$";
            // 
            // lbl_valor
            // 
            this.lbl_valor.AutoSize = true;
            this.lbl_valor.Location = new System.Drawing.Point(112, 422);
            this.lbl_valor.Name = "lbl_valor";
            this.lbl_valor.Size = new System.Drawing.Size(59, 22);
            this.lbl_valor.TabIndex = 13;
            this.lbl_valor.Text = "00,00";
            // 
            // daTime_data
            // 
            this.daTime_data.CalendarFont = new System.Drawing.Font("Century Gothic", 12.25F);
            this.daTime_data.CustomFormat = "yyyy-MM-dd";
            this.daTime_data.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.daTime_data.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.daTime_data.Location = new System.Drawing.Point(77, 153);
            this.daTime_data.Name = "daTime_data";
            this.daTime_data.Size = new System.Drawing.Size(365, 28);
            this.daTime_data.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 22);
            this.label6.TabIndex = 15;
            this.label6.Text = "Selecione a Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 22);
            this.label7.TabIndex = 17;
            this.label7.Text = "Selecione a Hora";
            // 
            // combobox_hora
            // 
            this.combobox_hora.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.combobox_hora.FormattingEnabled = true;
            this.combobox_hora.Items.AddRange(new object[] {
            "9:00h",
            "9:15h",
            "9:30h",
            "9:45h",
            "",
            "10:00h",
            "10:15h",
            "10:30h",
            "10:45h",
            "",
            "11:00h",
            "11:15h",
            "11:30h",
            "11:45h",
            "",
            "12:00h",
            "12:15h",
            "12:30h",
            "12:45h",
            "",
            "13:00h",
            "13:15h",
            "13:30h",
            "13:45h",
            "",
            "14:00h",
            "14:15h",
            "14:30h",
            "14:45h",
            "",
            "15:00h",
            "15:15h",
            "15:30h",
            "15:45h",
            "",
            "16:00h",
            "16:15h",
            "16:30h",
            "16:45h",
            "",
            "17:00h",
            "17:15h",
            "17:30h",
            "17:45h",
            "",
            "",
            ""});
            this.combobox_hora.Location = new System.Drawing.Point(448, 152);
            this.combobox_hora.Name = "combobox_hora";
            this.combobox_hora.Size = new System.Drawing.Size(160, 29);
            this.combobox_hora.TabIndex = 18;
            this.combobox_hora.TextChanged += new System.EventHandler(this.combobox_hora_TextChanged);
            this.combobox_hora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.combobox_hora_KeyPress);
            // 
            // btn_addServ
            // 
            this.btn_addServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_addServ.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btn_addServ.Location = new System.Drawing.Point(448, 231);
            this.btn_addServ.Name = "btn_addServ";
            this.btn_addServ.Size = new System.Drawing.Size(43, 40);
            this.btn_addServ.TabIndex = 19;
            this.btn_addServ.Text = ">";
            this.btn_addServ.UseVisualStyleBackColor = true;
            this.btn_addServ.Click += new System.EventHandler(this.select_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(497, 231);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(303, 163);
            this.dataGridView1.TabIndex = 20;
            // 
            // btn_removeServ
            // 
            this.btn_removeServ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_removeServ.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.btn_removeServ.Location = new System.Drawing.Point(448, 354);
            this.btn_removeServ.Name = "btn_removeServ";
            this.btn_removeServ.Size = new System.Drawing.Size(43, 40);
            this.btn_removeServ.TabIndex = 21;
            this.btn_removeServ.Text = "<";
            this.btn_removeServ.UseVisualStyleBackColor = true;
            this.btn_removeServ.Click += new System.EventHandler(this.btn_removeServ_Click);
            // 
            // marcarAtendimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_removeServ);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_addServ);
            this.Controls.Add(this.combobox_hora);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.daTime_data);
            this.Controls.Add(this.lbl_valor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_agendar);
            this.Controls.Add(this.gridViewServicos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.combobox_cliente);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "marcarAtendimento";
            this.Size = new System.Drawing.Size(1072, 676);
            this.Load += new System.EventHandler(this.marcarAtendimento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobox_cliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView gridViewServicos;
        private System.Windows.Forms.Button btn_agendar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_valor;
        private System.Windows.Forms.DateTimePicker daTime_data;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox combobox_hora;
        private System.Windows.Forms.Button btn_addServ;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_removeServ;
    }
}
