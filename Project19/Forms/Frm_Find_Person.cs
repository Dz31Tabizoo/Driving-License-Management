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
    public partial class Frm_Find_Person : KryptonForm
    {
        public Frm_Find_Person()
        {
            InitializeComponent();
        }

        
        public delegate void GetPersonEventHandler(object sender, int PERSid);

        public event GetPersonEventHandler EvGetPerson;


        private void btnExit_Click(object sender, EventArgs e)
        {
            int PerID = usrCrtlShowPersonInfoFilter1.PersID;

            if (PerID >0)
            {
                EvGetPerson?.Invoke(this, PerID);

                this.Close();
            }
            else
            {
                DialogResult res = MessageBox.Show("Please Select a Persone or Add a new one if not exist", "Person Select", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                if (res == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        
    }
}
