using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

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
        public Contacts(string name, string email, string phone, string role)
        {
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }


        //The MySqlConnection method is used to create a new MySqlConnection object and open a connection to the MySQL database.
        public MySqlConnection GetConnection()
        {
            MySqlConnection conn = new MySqlConnection(connString);

            try
            {
                conn.Open();
                MessageBox.Show("Connection Open");
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
    }
}
