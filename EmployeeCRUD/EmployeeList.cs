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

        private void EmployeeList_Load(object sender, EventArgs e)
        {
            Contacts contact = new Contacts();
            dgContacts.DataSource = contact.GetAllContacts();
        }

        private void dgContacts_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int idx = e.RowIndex;

            if (idx == -1 || dgContacts.SelectedCells[1].Value.ToString() == "")
            {
                MessageBox.Show("Select a valid row");
                ResetForm();
            }
            else
            {
                textId.Text = dgContacts.SelectedRows[0].Cells[0].Value.ToString();
                textName.Text = dgContacts.SelectedRows[0].Cells[1].Value.ToString();
                textEmail.Text = dgContacts.SelectedRows[0].Cells[2].Value.ToString();
                textPhone.Text = dgContacts.SelectedRows[0].Cells[3].Value.ToString();
                cmbRole.Text = dgContacts.SelectedRows[0].Cells[4].Value.ToString();

                btnSave.Enabled = false;
                btnDelete.Enabled = true;
                btnEdit.Enabled = true;
            }
        }

        // The ResetForm method is used to clear the textboxes and set the focus to the name textbox.
        public void ResetForm()
        {
            textId.Text = "";
            textName.Text = "";
            textEmail.Text = "";
            textPhone.Text = "";
            cmbRole.Text = "Select Role";

            btnSave.Enabled = true;
            btnDelete.Enabled = false;
            btnEdit.Enabled = false;

            textName.Focus();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the id from the textbox and convert it to integer
            int id = Convert.ToInt32(textId.Text);

            DialogResult confirm = MessageBox.Show("Are you sure you want to delete this record?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes) {

                Contacts contact = new Contacts();
                int rowsAffected = contact.DeleteContact(id);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Record Deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ResetForm();
                    Contacts newContact = new Contacts();
                    dgContacts.DataSource = newContact.GetAllContacts();
                }
                else
                {
                    MessageBox.Show("Record Not Deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else
            {
                ResetForm();
            }
        }
    }
}
