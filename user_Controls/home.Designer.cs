namespace AVfinal.user_Controls
{
    partial class home
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
            this.monthCalendarHome = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_atendimentos = new System.Windows.Forms.Label();
            this.concluded = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendarHome
            // 
            this.monthCalendarHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.monthCalendarHome.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.monthCalendarHome.Dock = System.Windows.Forms.DockStyle.Right;
            this.monthCalendarHome.ForeColor = System.Drawing.Color.White;
            this.monthCalendarHome.Location = new System.Drawing.Point(692, 0);
            this.monthCalendarHome.MaxSelectionCount = 1;
            this.monthCalendarHome.Name = "monthCalendarHome";
            this.monthCalendarHome.TabIndex = 0;
            this.monthCalendarHome.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarHome_DateChanged);
            this.monthCalendarHome.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendarHome_DateSelected);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 44);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(677, 284);
            this.dataGridView1.TabIndex = 1;
            // 
            // lbl_atendimentos
            // 
            this.lbl_atendimentos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_atendimentos.AutoSize = true;
            this.lbl_atendimentos.Location = new System.Drawing.Point(3, 17);
            this.lbl_atendimentos.Name = "lbl_atendimentos";
            this.lbl_atendimentos.Size = new System.Drawing.Size(291, 24);
            this.lbl_atendimentos.TabIndex = 2;
            this.lbl_atendimentos.Text = "Atendimentos do dia selecionado";
            // 
            // concluded
            // 
            this.concluded.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.concluded.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(136)))), ((int)(((byte)(56)))));
            this.concluded.Cursor = System.Windows.Forms.Cursors.Hand;
            this.concluded.FlatAppearance.BorderSize = 0;
            this.concluded.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concluded.ForeColor = System.Drawing.Color.Transparent;
            this.concluded.Location = new System.Drawing.Point(433, 334);
            this.concluded.Name = "concluded";
            this.concluded.Size = new System.Drawing.Size(247, 36);
            this.concluded.TabIndex = 3;
            this.concluded.Text = "Concluir Agendamento";
            this.concluded.UseVisualStyleBackColor = false;
            this.concluded.Click += new System.EventHandler(this.concluded_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.concluded);
            this.Controls.Add(this.lbl_atendimentos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendarHome);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "home";
            this.Size = new System.Drawing.Size(919, 456);
            this.Load += new System.EventHandler(this.home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendarHome;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_atendimentos;
        private System.Windows.Forms.Button concluded;
    }
}
