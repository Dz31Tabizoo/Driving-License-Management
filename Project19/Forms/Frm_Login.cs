using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace Project19
{
    public partial class Frm_Login : KryptonForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kryptonTextBox1.Focus();
            
        }

        

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            Form FRM = new Frm_Main_Menu();
            FRM.Show();
        }

       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
