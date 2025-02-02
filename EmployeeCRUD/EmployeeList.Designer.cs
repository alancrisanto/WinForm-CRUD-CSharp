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
            btnSave = new Button();
            cmbRole = new ComboBox();
            textPhone = new TextBox();
            textEmail = new TextBox();
            textName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSave);
            groupBox1.Controls.Add(cmbRole);
            groupBox1.Controls.Add(textPhone);
            groupBox1.Controls.Add(textEmail);
            groupBox1.Controls.Add(textName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(409, 245);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Management";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.HotTrack;
            btnSave.BackgroundImageLayout = ImageLayout.Center;
            btnSave.Cursor = Cursors.Hand;
            btnSave.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(21, 176);
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
            cmbRole.Location = new Point(84, 137);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(276, 25);
            cmbRole.TabIndex = 7;
            cmbRole.Text = "Select Role";
            // 
            // textPhone
            // 
            textPhone.Location = new Point(84, 102);
            textPhone.Name = "textPhone";
            textPhone.Size = new Size(276, 25);
            textPhone.TabIndex = 6;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(84, 67);
            textEmail.Name = "textEmail";
            textEmail.Size = new Size(276, 25);
            textEmail.TabIndex = 5;
            // 
            // textName
            // 
            textName.Location = new Point(84, 32);
            textName.Name = "textName";
            textName.Size = new Size(276, 25);
            textName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 141);
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
            label3.Location = new Point(15, 105);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(48, 19);
            label3.TabIndex = 2;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 69);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(41, 19);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 33);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(45, 19);
            label1.TabIndex = 0;
            label1.Text = "Name";
            label1.Click += label1_Click;
            // 
            // EmployeeList
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 407);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 10F);
            Name = "EmployeeList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Employees";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
    }
}
