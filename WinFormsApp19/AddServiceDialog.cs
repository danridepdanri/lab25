using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp19
{
    public partial class AddServiceDialog : Form
    {
        public int ServiceID { get; private set; }
        public int ResidentID { get; private set; }
        public string ServiceName { get; private set; }
        public DateTime ServiceDate { get; private set; }

        public AddServiceDialog()
        {
            InitializeComponent();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ServiceID = int.Parse(txtServiceID.Text);
                ResidentID = int.Parse(txtResidentID.Text);
                ServiceName = txtServiceName.Text;
                ServiceDate = dtpServiceDate.Value;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateInput()
        {
            // Perform validation for the input fields
            if (string.IsNullOrWhiteSpace(txtServiceID.Text) || string.IsNullOrWhiteSpace(txtResidentID.Text) ||
                string.IsNullOrWhiteSpace(txtServiceName.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
                return false;
            }

            if (!int.TryParse(txtServiceID.Text, out _))
            {
                MessageBox.Show("Service ID must be a valid integer.");
                return false;
            }

            if (!int.TryParse(txtResidentID.Text, out _))
            {
                MessageBox.Show("Resident ID must be a valid integer.");
                return false;
            }

            return true;
        }
    }
}
