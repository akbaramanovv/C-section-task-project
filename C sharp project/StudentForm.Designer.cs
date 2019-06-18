namespace C_sharp_project
{
    partial class StudentForm
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
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSdelete = new System.Windows.Forms.Button();
            this.btnSTsave = new System.Windows.Forms.Button();
            this.cbStudentGroups = new System.Windows.Forms.ComboBox();
            this.TxtSFee = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbGr = new System.Windows.Forms.Label();
            this.txtSSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgstudent = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phonee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchstudent = new System.Windows.Forms.TextBox();
            this.btnSsearch = new System.Windows.Forms.Button();
            this.btnshow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgstudent)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSCancel
            // 
            this.btnSCancel.Location = new System.Drawing.Point(279, 511);
            this.btnSCancel.Name = "btnSCancel";
            this.btnSCancel.Size = new System.Drawing.Size(108, 43);
            this.btnSCancel.TabIndex = 20;
            this.btnSCancel.Text = "Cancel";
            this.btnSCancel.UseVisualStyleBackColor = true;
            this.btnSCancel.Click += new System.EventHandler(this.BtnSCancel_Click);
            // 
            // btnSdelete
            // 
            this.btnSdelete.Location = new System.Drawing.Point(151, 511);
            this.btnSdelete.Name = "btnSdelete";
            this.btnSdelete.Size = new System.Drawing.Size(108, 43);
            this.btnSdelete.TabIndex = 21;
            this.btnSdelete.Text = "Delete";
            this.btnSdelete.UseVisualStyleBackColor = true;
            this.btnSdelete.Click += new System.EventHandler(this.BtnSdelete_Click);
            // 
            // btnSTsave
            // 
            this.btnSTsave.Location = new System.Drawing.Point(19, 511);
            this.btnSTsave.Name = "btnSTsave";
            this.btnSTsave.Size = new System.Drawing.Size(108, 43);
            this.btnSTsave.TabIndex = 22;
            this.btnSTsave.Text = "Save";
            this.btnSTsave.UseVisualStyleBackColor = true;
            this.btnSTsave.Click += new System.EventHandler(this.BtnSTsave_Click);
            // 
            // cbStudentGroups
            // 
            this.cbStudentGroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbStudentGroups.FormattingEnabled = true;
            this.cbStudentGroups.Location = new System.Drawing.Point(25, 201);
            this.cbStudentGroups.Name = "cbStudentGroups";
            this.cbStudentGroups.Size = new System.Drawing.Size(360, 33);
            this.cbStudentGroups.TabIndex = 19;
            // 
            // TxtSFee
            // 
            this.TxtSFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSFee.Location = new System.Drawing.Point(25, 446);
            this.TxtSFee.Name = "TxtSFee";
            this.TxtSFee.Size = new System.Drawing.Size(360, 30);
            this.TxtSFee.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 418);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Fee";
            // 
            // txtSPhone
            // 
            this.txtSPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSPhone.Location = new System.Drawing.Point(25, 368);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(360, 30);
            this.txtSPhone.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Phone";
            // 
            // txtSEmail
            // 
            this.txtSEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSEmail.Location = new System.Drawing.Point(25, 286);
            this.txtSEmail.Name = "txtSEmail";
            this.txtSEmail.Size = new System.Drawing.Size(362, 30);
            this.txtSEmail.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // cbGr
            // 
            this.cbGr.AutoSize = true;
            this.cbGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGr.Location = new System.Drawing.Point(20, 173);
            this.cbGr.Name = "cbGr";
            this.cbGr.Size = new System.Drawing.Size(76, 25);
            this.cbGr.TabIndex = 11;
            this.cbGr.Text = "Groups";
            // 
            // txtSSurname
            // 
            this.txtSSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSurname.Location = new System.Drawing.Point(25, 124);
            this.txtSSurname.Name = "txtSSurname";
            this.txtSSurname.Size = new System.Drawing.Size(364, 30);
            this.txtSSurname.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Surname";
            // 
            // txtSName
            // 
            this.txtSName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSName.Location = new System.Drawing.Point(25, 45);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(368, 30);
            this.txtSName.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // dvgstudent
            // 
            this.dvgstudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgstudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SName,
            this.Surname,
            this.Email,
            this.Phonee,
            this.Group,
            this.Phone,
            this.Remaining});
            this.dvgstudent.Location = new System.Drawing.Point(470, 124);
            this.dvgstudent.Name = "dvgstudent";
            this.dvgstudent.RowTemplate.Height = 24;
            this.dvgstudent.Size = new System.Drawing.Size(578, 430);
            this.dvgstudent.TabIndex = 23;
            this.dvgstudent.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvgstudent_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SName
            // 
            this.SName.HeaderText = "Name";
            this.SName.Name = "SName";
            this.SName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phonee
            // 
            this.Phonee.HeaderText = "Phone";
            this.Phonee.Name = "Phonee";
            this.Phonee.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Fee";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Remaining
            // 
            this.Remaining.HeaderText = "Remaining Debt";
            this.Remaining.Name = "Remaining";
            this.Remaining.ReadOnly = true;
            // 
            // txtSearchstudent
            // 
            this.txtSearchstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchstudent.Location = new System.Drawing.Point(470, 47);
            this.txtSearchstudent.Name = "txtSearchstudent";
            this.txtSearchstudent.Size = new System.Drawing.Size(441, 34);
            this.txtSearchstudent.TabIndex = 25;
            // 
            // btnSsearch
            // 
            this.btnSsearch.Location = new System.Drawing.Point(939, 47);
            this.btnSsearch.Name = "btnSsearch";
            this.btnSsearch.Size = new System.Drawing.Size(109, 38);
            this.btnSsearch.TabIndex = 24;
            this.btnSsearch.Text = "Search";
            this.btnSsearch.UseVisualStyleBackColor = true;
            this.btnSsearch.Click += new System.EventHandler(this.BtnSsearch_Click);
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(376, 644);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(108, 39);
            this.btnshow.TabIndex = 26;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.Btnshow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 655);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(347, 28);
            this.label3.TabIndex = 27;
            this.label3.Text = "Write mark with groups";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 718);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.txtSearchstudent);
            this.Controls.Add(this.btnSsearch);
            this.Controls.Add(this.dvgstudent);
            this.Controls.Add(this.btnSCancel);
            this.Controls.Add(this.btnSdelete);
            this.Controls.Add(this.btnSTsave);
            this.Controls.Add(this.cbStudentGroups);
            this.Controls.Add(this.TxtSFee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGr);
            this.Controls.Add(this.txtSSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.label1);
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.Activated += new System.EventHandler(this.StudentForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dvgstudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSdelete;
        private System.Windows.Forms.Button btnSTsave;
        private System.Windows.Forms.ComboBox cbStudentGroups;
        private System.Windows.Forms.TextBox TxtSFee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label cbGr;
        private System.Windows.Forms.TextBox txtSSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgstudent;
        private System.Windows.Forms.TextBox txtSearchstudent;
        private System.Windows.Forms.Button btnSsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phonee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remaining;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Label label3;
    }
}