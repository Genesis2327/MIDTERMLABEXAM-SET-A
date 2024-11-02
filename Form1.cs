using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Employee_Management_System
{
    public partial class Form1 : Form
    {
        private string connectionString = "Server=127.0.0.1;Database=EmployeeDB;User ID=root;Password=Password123;";
        private bool isConnected = false;

        public Form1()
        {
            InitializeComponent();
            ConnectToDatabase(); // Automatically connect to the database
            LoadEmployeeIDs();
        }

        private MySqlConnection GetConnection() => new MySqlConnection(connectionString);

        private void ShowMessage(string message, string title, MessageBoxIcon icon)
        {
            MessageBox.Show(message, title, MessageBoxButtons.OK, icon);
        }

        private void ExecuteWithErrorHandling(Action operation, string errorMessage)
        {
            if (!isConnected) return;
            try
            {
                operation.Invoke();
            }
            catch (MySqlException ex)
            {
                ShowMessage(errorMessage + ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        private void ConnectToDatabase()
        {
            using (var conn = GetConnection())
            {
                try
                {
                    conn.Open();
                    isConnected = true;
                    ShowMessage("Database connected successfully!", "Connection Status", MessageBoxIcon.Information);
                }
                catch (MySqlException ex)
                {
                    ShowMessage("Failed to connect to the database: " + ex.Message, "Connection Status", MessageBoxIcon.Error);
                    isConnected = false;
                }
            }
        }

        private void AddEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateEmployeeInputs(true)) return;

            ExecuteWithErrorHandling(() =>
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO Employees (FirstName, LastName, Email, Salary) VALUES (@FirstName, @LastName, @Email, @Salary)";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Salary", decimal.Parse(SalaryTextBox.Text));
                        cmd.ExecuteNonQuery();
                    }
                    LoadData();
                    LoadEmployeeIDs();
                    ShowMessage("Employee added successfully.", "Success", MessageBoxIcon.Information);
                    ClearEmployeeInputFields();
                }
            }, "Error adding employee: ");
        }

        private void ReadDisplayViewBtn_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void UpdateSalaryEmployeeIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UpdateSalaryEmployeeIDComboBox.SelectedItem is null) return;

            int employeeID = int.Parse(UpdateSalaryEmployeeIDComboBox.SelectedItem.ToString());
            ExecuteWithErrorHandling(() =>
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT Salary FROM Employees WHERE EmployeeID = @EmployeeID";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                        var salary = cmd.ExecuteScalar();
                        if (salary != null)
                        {
                            UpdatedSalaryTextBox.Text = salary.ToString();
                        }
                    }
                }
            }, "Error retrieving salary: ");
        }

        private void UpdateSalaryBtn_Click(object sender, EventArgs e)
        {
            if (UpdateSalaryEmployeeIDComboBox.SelectedItem is null)
            {
                ShowMessage("Please select an employee ID to update the salary.", "Validation Error", MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(UpdatedSalaryTextBox.Text))
            {
                ShowMessage("Salary field must be filled.", "Validation Error", MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(UpdatedSalaryTextBox.Text, out decimal newSalary) || newSalary < 0)
            {
                ShowMessage("Salary must be a non-negative number.", "Validation Error", MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to update the salary?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExecuteWithErrorHandling(() =>
                {
                    int employeeID = int.Parse(UpdateSalaryEmployeeIDComboBox.SelectedItem.ToString());
                    using (var conn = GetConnection())
                    {
                        conn.Open();
                        string query = "UPDATE Employees SET Salary = @Salary WHERE EmployeeID = @EmployeeID";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                            cmd.Parameters.AddWithValue("@Salary", newSalary);
                            cmd.ExecuteNonQuery();
                        }
                        LoadData();
                        ShowMessage("Salary updated successfully.", "Success", MessageBoxIcon.Information);
                        ClearUpdateSalaryFields();
                    }
                }, "Error updating salary: ");
            }
        }

        private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
        {
            if (RemoveEmployeeIDComboBox.SelectedItem is null)
            {
                ShowMessage("Please select an employee ID to delete.", "Validation Error", MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this employee?", "Confirm", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ExecuteWithErrorHandling(() =>
                {
                    int employeeID = int.Parse(RemoveEmployeeIDComboBox.SelectedItem.ToString());
                    using (var conn = GetConnection())
                    {
                        conn.Open();
                        string query = "DELETE FROM Employees WHERE EmployeeID = @EmployeeID";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@EmployeeID", employeeID);
                            cmd.ExecuteNonQuery();
                        }
                        LoadData();
                        LoadEmployeeIDs();
                        ShowMessage("Employee deleted successfully.", "Success", MessageBoxIcon.Information);
                        RemoveEmployeeIDComboBox.SelectedItem = null;
                    }
                }, "Error deleting employee: ");
            }
        }

        private void LoadData()
        {
            if (!isConnected) return;

            listView1.Items.Clear();
            ExecuteWithErrorHandling(() =>
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT * FROM Employees";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ListViewItem(reader["EmployeeID"].ToString())
                            {
                                SubItems =
                                {
                                    reader["FirstName"].ToString(),
                                    reader["LastName"].ToString(),
                                    reader["Email"].ToString(),
                                    reader["Salary"].ToString()
                                }
                            };
                            listView1.Items.Add(item);
                        }
                    }
                }
            }, "Error loading employee data: ");
        }

        private void LoadEmployeeIDs()
        {
            UpdateSalaryEmployeeIDComboBox.Items.Clear();
            RemoveEmployeeIDComboBox.Items.Clear();
            ExecuteWithErrorHandling(() =>
            {
                using (var conn = GetConnection())
                {
                    conn.Open();
                    string query = "SELECT EmployeeID FROM Employees";
                    using (var cmd = new MySqlCommand(query, conn))
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employeeID = reader["EmployeeID"].ToString();
                            UpdateSalaryEmployeeIDComboBox.Items.Add(employeeID);
                            RemoveEmployeeIDComboBox.Items.Add(employeeID);
                        }
                    }
                }
            }, "Error loading employee IDs: ");
        }

        private bool ValidateEmployeeInputs(bool isAdding)
        {
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(LastNameTextBox.Text) ||
                string.IsNullOrWhiteSpace(EmailTextBox.Text) ||
                string.IsNullOrWhiteSpace(SalaryTextBox.Text))
            {
                ShowMessage("All fields must be filled:\n- First Name\n- Last Name\n- Email\n- Salary", "Validation Error", MessageBoxIcon.Warning);
                return false;
            }

            var namePattern = @"^[A-Za-z\s-]+$";
            if (!Regex.IsMatch(FirstNameTextBox.Text, namePattern) || !Regex.IsMatch(LastNameTextBox.Text, namePattern))
            {
                ShowMessage("First Name and Last Name must only contain letters, spaces, and hyphens.", "Validation Error", MessageBoxIcon.Warning);
                return false;
            }

            var emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (!Regex.IsMatch(EmailTextBox.Text, emailPattern))
            {
                ShowMessage("Please enter a valid email address.", "Validation Error", MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(SalaryTextBox.Text, out decimal salary) || salary < 0)
            {
                ShowMessage("Salary must be a non-negative number.", "Validation Error", MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void ClearEmployeeInputFields()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            EmailTextBox.Clear();
            SalaryTextBox.Clear();
        }

        private void ClearUpdateSalaryFields()
        {
            UpdateSalaryEmployeeIDComboBox.SelectedItem = null;
            UpdatedSalaryTextBox.Clear();
        }
    }
}
