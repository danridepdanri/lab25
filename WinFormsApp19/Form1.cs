using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp19
{
    public partial class Form1 : Form
    {
        private MySqlConnection connection;
        private string connectionString = "Server=127.0.0.1;Port=3306;Database=housing;Uid=root;";

        public Form1()
        {
            InitializeComponent();
            connection = new MySqlConnection(connectionString);
            ConnectToDatabase();
        }

        private void ConnectToDatabase()
        {
            try
            {
                connection.Open();
                MessageBox.Show("Connection established successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnAddBuilding_Click(object sender, EventArgs e)
        {
            AddBuildingDialog dialog = new AddBuildingDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int buildingID = dialog.BuildingID;
                string address = dialog.Address;
                int floors = dialog.NumberOfFloors;
                double area = dialog.TotalArea;

                string query = "INSERT INTO Buildings (ID, Address, NumberOfFloors, TotalArea) VALUES (@ID, @Address, @Floors, @Area)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", buildingID);
                command.Parameters.AddWithValue("@Address", address);
                command.Parameters.AddWithValue("@Floors", floors);
                command.Parameters.AddWithValue("@Area", area);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Building data added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding building data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnAddResident_Click(object sender, EventArgs e)
        {
            AddResidentDialog dialog = new AddResidentDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int residentID = dialog.ResidentID;
                string lastName = dialog.LastName;
                string firstName = dialog.FirstName;
                string contactNumber = dialog.ContactNumber;

                string query = "INSERT INTO Residents (ID, LastName, FirstName, ContactNumber) VALUES (@ID, @LastName, @FirstName, @ContactNumber)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", residentID);
                command.Parameters.AddWithValue("@LastName", lastName);
                command.Parameters.AddWithValue("@FirstName", firstName);
                command.Parameters.AddWithValue("@ContactNumber", contactNumber);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Resident data added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding resident data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            AddServiceDialog dialog = new AddServiceDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                int serviceID = dialog.ServiceID;
                int residentID = dialog.ResidentID;
                string serviceName = dialog.ServiceName;
                DateTime serviceDate = dialog.ServiceDate;

                string query = "INSERT INTO Services (ID, ResidentID, ServiceName, ServiceDate) VALUES (@ID, @ResidentID, @ServiceName, @ServiceDate)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", serviceID);
                command.Parameters.AddWithValue("@ResidentID", residentID);
                command.Parameters.AddWithValue("@ServiceName", serviceName);
                command.Parameters.AddWithValue("@ServiceDate", serviceDate);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Service data added successfully!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error adding service data: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void btnGenerateReport1_Click(object sender, EventArgs e)
        {
            string query = "SELECT Address, NumberOfFloors FROM Buildings";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
        }

        private void btnGenerateReport2_Click(object sender, EventArgs e)
        {
            string query = "SELECT Residents.LastName, Residents.FirstName, Services.ServiceName, Services.ServiceDate FROM Residents INNER JOIN Services ON Residents.ID = Services.ResidentID";
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchCriterion = txtSearchCriterion.Text;
            string query = "SELECT * FROM Buildings WHERE Address LIKE @SearchCriterion";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@SearchCriterion", "%" + searchCriterion + "%");

            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            dataGridView.DataSource = dataTable;
        }
    }
}