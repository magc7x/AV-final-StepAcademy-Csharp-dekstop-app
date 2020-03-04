using AVfinal.util_forms;
using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AVfinal
{
    public partial class Inicial : Form
    {
        public Inicial()
        {  
           InitializeComponent();
        }


        private void Inicial_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Network net = new Network();
            if (net.IsAvailable == false)
            {
                noConn noConnForm = new noConn();
                noConnForm.Show();
            } else
            {
                this.Hide();

                AppMainForm app = new AppMainForm();
                app.Show();
            }
       
        }
    }

}
