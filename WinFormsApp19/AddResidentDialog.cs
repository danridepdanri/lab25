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
    public partial class AddResidentDialog : Form
    {
        public int ResidentID { get; private set; }
        public string LastName { get; private set; }
        public string FirstName { get; private set; }
        public string ContactNumber { get; private set; }

        public AddResidentDialog()
        {
            InitializeComponent();
        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                ResidentID = int.Parse(txtResidentID.Text);
                LastName = txtLastName.Text;
                FirstName = txtFirstName.Text;
                ContactNumber = txtContactNumber.Text;

                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private bool ValidateInput()
        {
            // Perform validation for the input fields
            if (string.IsNullOrWhiteSpace(txtResidentID.Text) || string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtContactNumber.Text))
            {
                MessageBox.Show("Please fill in all the fields.");
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
