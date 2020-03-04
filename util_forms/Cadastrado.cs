using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AVfinal.util_forms
{
    public partial class Cadastrado : Form
    {
        public Cadastrado(string lblmsg)
        {
            InitializeComponent();
            label1.Text = lblmsg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
