namespace Employee_Management_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmployeeData = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AddEmployeeLbl = new System.Windows.Forms.Label();
            this.SalaryTextBox = new System.Windows.Forms.TextBox();
            this.AddEmployeeBtn = new System.Windows.Forms.Button();
            this.SalaryLbl = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLbl = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLbl = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReadDisplayViewBtn = new System.Windows.Forms.Button();
            this.RemoveEmployeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.RemoveEmployeeIDLbl = new System.Windows.Forms.Label();
            this.DeleteEmployeeBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UpdateSalaryBtn = new System.Windows.Forms.Button();
            this.UpdatedSalaryLbl = new System.Windows.Forms.Label();
            this.UpdateSalaryEmployeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateSalaryEmployeeIDLbl = new System.Windows.Forms.Label();
            this.UpdatedSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1077, 70);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(324, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee Management System";
            // 
            // EmployeeData
            // 
            this.EmployeeData.AutoSize = true;
            this.EmployeeData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EmployeeData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeData.Location = new System.Drawing.Point(312, 10);
            this.EmployeeData.Name = "EmployeeData";
            this.EmployeeData.Size = new System.Drawing.Size(191, 25);
            this.EmployeeData.TabIndex = 1;
            this.EmployeeData.Text = "Employee\'s Table:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AddEmployeeLbl);
            this.panel2.Controls.Add(this.SalaryTextBox);
            this.panel2.Controls.Add(this.AddEmployeeBtn);
            this.panel2.Controls.Add(this.SalaryLbl);
            this.panel2.Controls.Add(this.EmailTextBox);
            this.panel2.Controls.Add(this.EmailLbl);
            this.panel2.Controls.Add(this.LastNameTextBox);
            this.panel2.Controls.Add(this.LastNameLbl);
            this.panel2.Controls.Add(this.FirstNameTextBox);
            this.panel2.Controls.Add(this.FirstNameLbl);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.EmployeeData);
            this.panel2.Location = new System.Drawing.Point(13, 89);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1052, 290);
            this.panel2.TabIndex = 3;
            // 
            // AddEmployeeLbl
            // 
            this.AddEmployeeLbl.AutoSize = true;
            this.AddEmployeeLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddEmployeeLbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeLbl.Location = new System.Drawing.Point(12, 10);
            this.AddEmployeeLbl.Name = "AddEmployeeLbl";
            this.AddEmployeeLbl.Size = new System.Drawing.Size(161, 23);
            this.AddEmployeeLbl.TabIndex = 11;
            this.AddEmployeeLbl.Text = "Add Employee:";
            // 
            // SalaryTextBox
            // 
            this.SalaryTextBox.Location = new System.Drawing.Point(116, 199);
            this.SalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SalaryTextBox.Name = "SalaryTextBox";
            this.SalaryTextBox.Size = new System.Drawing.Size(176, 22);
            this.SalaryTextBox.TabIndex = 10;
            // 
            // AddEmployeeBtn
            // 
            this.AddEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.AddEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeeBtn.Location = new System.Drawing.Point(179, 236);
            this.AddEmployeeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddEmployeeBtn.Name = "AddEmployeeBtn";
            this.AddEmployeeBtn.Size = new System.Drawing.Size(133, 39);
            this.AddEmployeeBtn.TabIndex = 12;
            this.AddEmployeeBtn.Text = "Add ";
            this.AddEmployeeBtn.UseVisualStyleBackColor = false;
            this.AddEmployeeBtn.Click += new System.EventHandler(this.AddEmployeeBtn_Click);
            // 
            // SalaryLbl
            // 
            this.SalaryLbl.AutoSize = true;
            this.SalaryLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.SalaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalaryLbl.Location = new System.Drawing.Point(21, 202);
            this.SalaryLbl.Name = "SalaryLbl";
            this.SalaryLbl.Size = new System.Drawing.Size(56, 16);
            this.SalaryLbl.TabIndex = 9;
            this.SalaryLbl.Text = "Salary:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(77, 148);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(215, 22);
            this.EmailTextBox.TabIndex = 8;
            // 
            // EmailLbl
            // 
            this.EmailLbl.AutoSize = true;
            this.EmailLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EmailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLbl.Location = new System.Drawing.Point(21, 151);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(50, 16);
            this.EmailLbl.TabIndex = 7;
            this.EmailLbl.Text = "Email:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(116, 102);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.LastNameTextBox.TabIndex = 6;
            // 
            // LastNameLbl
            // 
            this.LastNameLbl.AutoSize = true;
            this.LastNameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LastNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameLbl.Location = new System.Drawing.Point(21, 105);
            this.LastNameLbl.Name = "LastNameLbl";
            this.LastNameLbl.Size = new System.Drawing.Size(78, 16);
            this.LastNameLbl.TabIndex = 5;
            this.LastNameLbl.Text = "Lastname:";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(116, 53);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(176, 22);
            this.FirstNameTextBox.TabIndex = 4;
            // 
            // FirstNameLbl
            // 
            this.FirstNameLbl.AutoSize = true;
            this.FirstNameLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.FirstNameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameLbl.Location = new System.Drawing.Point(21, 55);
            this.FirstNameLbl.Name = "FirstNameLbl";
            this.FirstNameLbl.Size = new System.Drawing.Size(79, 16);
            this.FirstNameLbl.TabIndex = 3;
            this.FirstNameLbl.Text = "Firstname:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(317, 53);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(719, 222);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "EmployeeID";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FirstName";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "LastName";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email ";
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = " Salary ";
            this.columnHeader5.Width = 90;
            // 
            // ReadDisplayViewBtn
            // 
            this.ReadDisplayViewBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ReadDisplayViewBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReadDisplayViewBtn.Location = new System.Drawing.Point(932, 383);
            this.ReadDisplayViewBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReadDisplayViewBtn.Name = "ReadDisplayViewBtn";
            this.ReadDisplayViewBtn.Size = new System.Drawing.Size(133, 39);
            this.ReadDisplayViewBtn.TabIndex = 13;
            this.ReadDisplayViewBtn.Text = "View";
            this.ReadDisplayViewBtn.UseVisualStyleBackColor = false;
            this.ReadDisplayViewBtn.Click += new System.EventHandler(this.ReadDisplayViewBtn_Click);
            // 
            // RemoveEmployeeIDComboBox
            // 
            this.RemoveEmployeeIDComboBox.FormattingEnabled = true;
            this.RemoveEmployeeIDComboBox.Location = new System.Drawing.Point(608, 450);
            this.RemoveEmployeeIDComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemoveEmployeeIDComboBox.Name = "RemoveEmployeeIDComboBox";
            this.RemoveEmployeeIDComboBox.Size = new System.Drawing.Size(160, 24);
            this.RemoveEmployeeIDComboBox.TabIndex = 24;
            // 
            // RemoveEmployeeIDLbl
            // 
            this.RemoveEmployeeIDLbl.AutoSize = true;
            this.RemoveEmployeeIDLbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.RemoveEmployeeIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveEmployeeIDLbl.Location = new System.Drawing.Point(499, 453);
            this.RemoveEmployeeIDLbl.Name = "RemoveEmployeeIDLbl";
            this.RemoveEmployeeIDLbl.Size = new System.Drawing.Size(96, 16);
            this.RemoveEmployeeIDLbl.TabIndex = 19;
            this.RemoveEmployeeIDLbl.Text = "EmployeeID:";
            // 
            // DeleteEmployeeBtn
            // 
            this.DeleteEmployeeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.DeleteEmployeeBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteEmployeeBtn.Location = new System.Drawing.Point(793, 453);
            this.DeleteEmployeeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
            this.DeleteEmployeeBtn.Size = new System.Drawing.Size(133, 39);
            this.DeleteEmployeeBtn.TabIndex = 14;
            this.DeleteEmployeeBtn.Text = "Delete";
            this.DeleteEmployeeBtn.UseVisualStyleBackColor = false;
            this.DeleteEmployeeBtn.Click += new System.EventHandler(this.DeleteEmployeeBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 400);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 23);
            this.label3.TabIndex = 24;
            this.label3.Text = "Remove Employee:";
            // 
            // UpdateSalaryBtn
            // 
            this.UpdateSalaryBtn.BackColor = System.Drawing.Color.Cyan;
            this.UpdateSalaryBtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSalaryBtn.Location = new System.Drawing.Point(331, 453);
            this.UpdateSalaryBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateSalaryBtn.Name = "UpdateSalaryBtn";
            this.UpdateSalaryBtn.Size = new System.Drawing.Size(133, 39);
            this.UpdateSalaryBtn.TabIndex = 13;
            this.UpdateSalaryBtn.Text = "Update ";
            this.UpdateSalaryBtn.UseVisualStyleBackColor = false;
            this.UpdateSalaryBtn.Click += new System.EventHandler(this.UpdateSalaryBtn_Click);
            // 
            // UpdatedSalaryLbl
            // 
            this.UpdatedSalaryLbl.AutoSize = true;
            this.UpdatedSalaryLbl.BackColor = System.Drawing.Color.Cyan;
            this.UpdatedSalaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatedSalaryLbl.Location = new System.Drawing.Point(37, 487);
            this.UpdatedSalaryLbl.Name = "UpdatedSalaryLbl";
            this.UpdatedSalaryLbl.Size = new System.Drawing.Size(120, 16);
            this.UpdatedSalaryLbl.TabIndex = 21;
            this.UpdatedSalaryLbl.Text = "Updated Salary:";
            // 
            // UpdateSalaryEmployeeIDComboBox
            // 
            this.UpdateSalaryEmployeeIDComboBox.FormattingEnabled = true;
            this.UpdateSalaryEmployeeIDComboBox.Location = new System.Drawing.Point(145, 438);
            this.UpdateSalaryEmployeeIDComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateSalaryEmployeeIDComboBox.Name = "UpdateSalaryEmployeeIDComboBox";
            this.UpdateSalaryEmployeeIDComboBox.Size = new System.Drawing.Size(160, 24);
            this.UpdateSalaryEmployeeIDComboBox.TabIndex = 23;
            this.UpdateSalaryEmployeeIDComboBox.SelectedIndexChanged += new System.EventHandler(this.UpdateSalaryEmployeeIDComboBox_SelectedIndexChanged);
            // 
            // UpdateSalaryEmployeeIDLbl
            // 
            this.UpdateSalaryEmployeeIDLbl.AutoSize = true;
            this.UpdateSalaryEmployeeIDLbl.BackColor = System.Drawing.Color.Cyan;
            this.UpdateSalaryEmployeeIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateSalaryEmployeeIDLbl.Location = new System.Drawing.Point(35, 441);
            this.UpdateSalaryEmployeeIDLbl.Name = "UpdateSalaryEmployeeIDLbl";
            this.UpdateSalaryEmployeeIDLbl.Size = new System.Drawing.Size(96, 16);
            this.UpdateSalaryEmployeeIDLbl.TabIndex = 17;
            this.UpdateSalaryEmployeeIDLbl.Text = "EmployeeID:";
            // 
            // UpdatedSalaryTextBox
            // 
            this.UpdatedSalaryTextBox.Location = new System.Drawing.Point(173, 484);
            this.UpdatedSalaryTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdatedSalaryTextBox.Name = "UpdatedSalaryTextBox";
            this.UpdatedSalaryTextBox.Size = new System.Drawing.Size(132, 22);
            this.UpdatedSalaryTextBox.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Cyan;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Update Salary:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 524);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeleteEmployeeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RemoveEmployeeIDLbl);
            this.Controls.Add(this.UpdatedSalaryTextBox);
            this.Controls.Add(this.RemoveEmployeeIDComboBox);
            this.Controls.Add(this.UpdateSalaryEmployeeIDLbl);
            this.Controls.Add(this.UpdateSalaryEmployeeIDComboBox);
            this.Controls.Add(this.ReadDisplayViewBtn);
            this.Controls.Add(this.UpdatedSalaryLbl);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.UpdateSalaryBtn);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label EmployeeData;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox SalaryTextBox;
        private System.Windows.Forms.Label SalaryLbl;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label EmailLbl;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLbl;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLbl;
        private System.Windows.Forms.Label AddEmployeeLbl;
        private System.Windows.Forms.Button AddEmployeeBtn;
        private System.Windows.Forms.Button ReadDisplayViewBtn;
        private System.Windows.Forms.ComboBox RemoveEmployeeIDComboBox;
        private System.Windows.Forms.Label RemoveEmployeeIDLbl;
        private System.Windows.Forms.Button DeleteEmployeeBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button UpdateSalaryBtn;
        private System.Windows.Forms.Label UpdatedSalaryLbl;
        private System.Windows.Forms.ComboBox UpdateSalaryEmployeeIDComboBox;
        private System.Windows.Forms.Label UpdateSalaryEmployeeIDLbl;
        private System.Windows.Forms.TextBox UpdatedSalaryTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

