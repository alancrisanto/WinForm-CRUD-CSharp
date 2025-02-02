using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace EmployeeCRUD
{
    internal class Contacts
    {
        //class Fields
        private int id;
        private string name;
        private string email;
        private string phone;
        private string role;


        //MySql Connection String
        string connString = "server=localhost;uid=root;pwd=root;database=employeelist;";


        //The constructor initializes a new instance of the Contacts class with the provided name, email, phone, and role.
        public Contacts(int id, string name, string email, string phone, string role)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }

        //The default constructor initializes a new instance of the Contacts class with default values.
        public Contacts () { }

        public Contacts (int id)
        {
            this.id = id;
        }


        //The MySqlConnection method is used to create a new MySqlConnection object and open a connection to the MySQL database.
        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                //MessageBox.Show("Connection Open");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            return conn;
        }

        // The GetAllContacts method is used to retrieve all contacts from the contacts table in the MySQL database.
        public DataTable GetAllContacts()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = GetConnection())
            {
                conn.Open(); // Open the connection
                string query = "SELECT * FROM employees";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                conn.Close(); // Close the connection
            }

            return dt;
        }

        // The AddContact method is used to add a new contact to the contacts table in the MySQL database.
        public int AddContact()
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open(); // Open the connection
                    string query = "INSERT INTO employees (name, email, phone, role) VALUES (@name, @email, @phone, @role)";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@role", role);
                    int rowsAdded = cmd.ExecuteNonQuery();
                    conn.Close(); // Close the connection
                    return rowsAdded;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0; // Return 0 in case of an error
            }
        }

        // The UpdateContact method is used to update a contact in the contacts table in the MySQL database.
        public int UpdateContact(int id)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open(); // Open the connection
                    string query = "UPDATE employees SET name = @name, email = @email, phone = @phone, role = @role WHERE employees_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@phone", phone);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsUpdated = cmd.ExecuteNonQuery();
                    conn.Close(); // Close the connection
                    return rowsUpdated;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0; // Return 0 in case of an error
            }
        }

        // The DeleteContact method is used to delete a contact from the contacts table in the MySQL database.
        public int DeleteContact(int id)
        {
            try
            {
                using (MySqlConnection conn = GetConnection())
                {
                    conn.Open(); // Open the connection
                    string query = "DELETE FROM employees WHERE employees_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int rowsDeleted = cmd.ExecuteNonQuery();
                    conn.Close(); // Close the connection
                    return rowsDeleted;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0; // Return 0 in case of an error
            }
        }
    }
}
