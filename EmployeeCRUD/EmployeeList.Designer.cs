namespace EmployeeCRUD
{
    partial class EmployeeList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textId = new TextBox();
            label6 = new Label();
            label5 = new Label();
            btnCancel = new Button();
            btnDelete = new Button();
            btnEdit = new Button();
            btnSave = new Button();
            cmbRole = new ComboBox();
            textPhone = new TextBox();
            textEmail = new TextBox();
            textName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgContacts = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textId);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnCancel);
            groupBox1.Controls.Add(btnDelete);
            groupBox1.Controls.Add(btnEdit);
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(cmbRole);
            groupBox1.Controls.Add(textPhone);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 272);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Management";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textId
            // 
            textId.Location = new Point(84, 41);
            textId.Name = "textId";
            textId.ReadOnly = true;
            textId.Size = new Size(276, 25);
            textId.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(15, 44);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(21, 19);
            label6.TabIndex = 12;
            label6.Text = "Id";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightSlateGray;
            btnCancel.BackgroundImageLayout = ImageLayout.Center;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(285, 223);
            btnCancel.Margin = new Padding(0);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 29);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.BackgroundImageLayout = ImageLayout.None;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.Enabled = false;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(195, 223);
            btnDelete.Margin = new Padding(0);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 29);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.MediumTurquoise;
            btnEdit.BackgroundImageLayout = ImageLayout.Center;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.Enabled = false;
            btnEdit.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnEdit.ForeColor = SystemColors.ButtonHighlight;
            btnEdit.Location = new Point(109, 223);
            btnEdit.Margin = new Padding(0);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 29);
            btnEdit.TabIndex = 9;
            btnEdit.Text = "Save";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.BackgroundImageLayout = ImageLayout.Center;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(21, 223);
            btnSave.Margin = new Padding(0);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 8;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Manager", "Developer", "Cloud Engineer", "Scrum Master", "Accounter", "Lawyer" });
            cmbRole.Location = new Point(84, 181);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(276, 25);
            cmbRole.TabIndex = 7;
            cmbRole.Text = "Select Role";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(84, 146);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(276, 25);
            textPhone.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(84, 111);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(276, 25);
            textEmail.TabIndex = 5;
            // 
            // textName
            // 
            textName.Location = new Point(84, 76);
            textName.Name = "textName";
            textName.Size = new Size(276, 25);
            textName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 188);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(35, 19);
            label4.TabIndex = 3;
            label4.Text = "Role";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 152);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(48, 19);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 116);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(41, 19);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 80);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // dgContacts
            // 
            dgContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgContacts.Location = new Point(444, 12);
            dgContacts.Name = "dgContacts";
            dgContacts.ReadOnly = true;
            dgContacts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgContacts.Size = new Size(565, 267);
            dgContacts.TabIndex = 2;
            dgContacts.CellMouseClick += dgContacts_CellMouseClick;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 487);
            Controls.Add(dgContacts);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            Name = "EmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            Load += EmployeeList_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgContacts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private TextBox textPhone;
        private TextBox textEmail;
        private TextBox textName;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmbRole;
        private Button btnSave;
        private DataGridView dgContacts;
        private Button btnCancel;
        private Button btnDelete;
        private Button btnEdit;
        private Label label5;
        private TextBox textId;
        private Label label6;
    }
}
