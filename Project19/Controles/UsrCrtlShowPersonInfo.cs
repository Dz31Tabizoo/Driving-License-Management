using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design;
using System.Windows.Forms;

namespace Project19
{
    public partial class UsCrtlPersonCard : UserControl
    {
        public UsCrtlPersonCard()
        {
            InitializeComponent();           
        }

        public void LoadPersonData(DataGridViewRow row)
        {
            lblPersonIdOutput.Text = row.Cells["PersonID"].Value?.ToString() ?? "N/A";
            lblNationalNoOutput.Text = row.Cells["NationalNo"].Value.ToString();
            lblNameOutput.Text = (row.Cells["FirstName"].Value?.ToString() ?? "N/A"); // + " " + (row.Cells["SecondName"].Value?.ToString() ?? "N/A") + " " + (row.Cells["ThirdName"].Value?.ToString() ?? "N/A") + " " + (row.Cells["LastName"].Value?.ToString() ?? "N/A");
            if ( row.Cells["DateOfBirth"].Value is DateTime dateTimeValue )
            {
                lblDateOfBirthOutput.Text = dateTimeValue.ToString("g");
            }
            object GENDOR = row.Cells["Gendor"].Value;
            if (GENDOR?.ToString() == "0")
            {
                lblGenderOutput.Text = "Male";
                pictureBox1.Image = Properties.Resources.male;
            }
            else
            {
                lblGenderOutput.Text = "Female";
                pictureBox1.Image = Properties.Resources.muslimah;

            }
                lblAddressOutput.Text = row.Cells["Address"].Value.ToString(); 
            lblPhoneOutput.Text = row.Cells["Phone"].Value.ToString();
            lblEmailOut.Text = row.Cells["Email"].Value.ToString();

        }

        
    }
}
