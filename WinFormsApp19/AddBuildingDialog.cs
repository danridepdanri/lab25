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
    public partial class AddBuildingDialog : Form
    {
        public int BuildingID { get; private set; }
        public string Address { get; private set; }
        public int NumberOfFloors { get; private set; }
        public double TotalArea { get; private set; }

        public AddBuildingDialog()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Получение данных из элементов управления диалогового окна
            BuildingID = int.Parse(txtBuildingID.Text);
            Address = txtAddress.Text;
            NumberOfFloors = int.Parse(txtFloors.Text);
            TotalArea = double.Parse(txtArea.Text);

            // Проверка наличия заполненных данных
            if (BuildingID == 0 || string.IsNullOrEmpty(Address) || NumberOfFloors == 0 || TotalArea == 0)
            {
                MessageBox.Show("Please fill in all the fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

    }
}
