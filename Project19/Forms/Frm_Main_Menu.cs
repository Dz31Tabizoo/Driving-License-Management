using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using System.Runtime.InteropServices;

namespace Project19
{
    public partial class Frm_Main_Menu : KryptonForm
    {
        private PrivateFontCollection privateFonts = new PrivateFontCollection();

        private void LoadFont()
        {
            try
            {

                privateFonts.AddFontFile("C:\\Users\\DELL\\Source\\Repos\\Driving-License-Management\\Project19\\Resources\\MarkaziText-VariableFont_wght.ttf");

                ApplyFontToControls(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load Poppins font: " + ex.Message);
            }
        }

        private void ApplyFontToControls(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Label || c is Button || c is TextBox || c is ComboBox)
                {
                    c.Font = new Font(privateFonts.Families[0], c.Font.Size, c.Font.Style);
                }

                // Recursively apply to child controls
                if (c.HasChildren)
                {
                    ApplyFontToControls(c);
                }
            }
        }

        // Clean up
     
        public Frm_Main_Menu()
        {
            InitializeComponent();
            LoadFont();
            CostumTools();
        }
        


        public void CostumTools()
        {
            kryptonPanel2.Visible = false;

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            if (kryptonPanel2.Visible == false)
            {
                kryptonPanel2.Visible= true;
                return;
            }
            else
            {
                kryptonPanel2.Visible = false;
            }

        }

        private void btnPeopleMng_Click(object sender, EventArgs e)
        {
            KryptonForm frm = new People_Managment();
            frm.Show();

        }

        private void kryptonButton1_Click_1(object sender, EventArgs e)
        {
            KryptonForm frm = new Frm_User_Managment();
            frm.Show();
        }

        private void kryptonButton7_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
