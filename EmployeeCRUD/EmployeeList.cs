namespace EmployeeCRUD
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        // 
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Get the values from the textboxes
            string name = textName.Text;
            string email = textEmail.Text;
            string phone = textPhone.Text;
            string role = cmbRole.Text;

            // Check if the fields are empty
            if (name == "" || email == "" || phone == "" || role == "Select Role")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                // Create a new instance of the Contacts class
                Contacts newContact = new Contacts(name, email, phone, role);
                int rowsAffected = newContact.AddContact();

                // Check if the data was saved
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the textboxes
                    textName.Text = "";
                    textEmail.Text = "";
                    textPhone.Text = "";
                    cmbRole.Text = "Select Role";
                }
                else
                {
                    MessageBox.Show("Data Not Saved", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
