namespace C_sharp_project
{
    partial class Muellimler
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
            this.dvgTeacherss = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Speiality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTsearch = new System.Windows.Forms.Button();
            this.txtSearchClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.cbSpc = new System.Windows.Forms.ComboBox();
            this.btnTsave = new System.Windows.Forms.Button();
            this.btnTdelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnshoww = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.slry = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTeacherss)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgTeacherss
            // 
            this.dvgTeacherss.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTeacherss.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tname,
            this.Surname,
            this.Speiality,
            this.Email,
            this.Phone,
            this.Salary});
            this.dvgTeacherss.Location = new System.Drawing.Point(570, 120);
            this.dvgTeacherss.Name = "dvgTeacherss";
            this.dvgTeacherss.RowTemplate.Height = 24;
            this.dvgTeacherss.Size = new System.Drawing.Size(542, 450);
            this.dvgTeacherss.TabIndex = 0;
            this.dvgTeacherss.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgTeacherss_CellDoubleClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Tname
            // 
            this.Tname.HeaderText = "Name";
            this.Tname.Name = "Tname";
            this.Tname.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Speiality
            // 
            this.Speiality.HeaderText = "Speciality";
            this.Speiality.Name = "Speiality";
            this.Speiality.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // btnTsearch
            // 
            this.btnTsearch.Location = new System.Drawing.Point(1003, 61);
            this.btnTsearch.Name = "btnTsearch";
            this.btnTsearch.Size = new System.Drawing.Size(109, 38);
            this.btnTsearch.TabIndex = 2;
            this.btnTsearch.Text = "Search";
            this.btnTsearch.UseVisualStyleBackColor = true;
            this.btnTsearch.Click += new System.EventHandler(this.BtnTsearch_Click);
            // 
            // txtSearchClient
            // 
            this.txtSearchClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClient.Location = new System.Drawing.Point(570, 65);
            this.txtSearchClient.Name = "txtSearchClient";
            this.txtSearchClient.Size = new System.Drawing.Size(410, 34);
            this.txtSearchClient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(25, 67);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(368, 30);
            this.txtName.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Surname";
            // 
            // txtSurname
            // 
            this.txtSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSurname.Location = new System.Drawing.Point(27, 140);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(364, 30);
            this.txtSurname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Speciality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(26, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(29, 302);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(362, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(25, 384);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(360, 30);
            this.txtPhone.TabIndex = 5;
            // 
            // cbSpc
            // 
            this.cbSpc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSpc.FormattingEnabled = true;
            this.cbSpc.Location = new System.Drawing.Point(31, 217);
            this.cbSpc.Name = "cbSpc";
            this.cbSpc.Size = new System.Drawing.Size(360, 33);
            this.cbSpc.TabIndex = 6;
            // 
            // btnTsave
            // 
            this.btnTsave.Location = new System.Drawing.Point(25, 527);
            this.btnTsave.Name = "btnTsave";
            this.btnTsave.Size = new System.Drawing.Size(108, 43);
            this.btnTsave.TabIndex = 7;
            this.btnTsave.Text = "Save";
            this.btnTsave.UseVisualStyleBackColor = true;
            this.btnTsave.Click += new System.EventHandler(this.BtnTsave_Click);
            // 
            // btnTdelete
            // 
            this.btnTdelete.Location = new System.Drawing.Point(157, 527);
            this.btnTdelete.Name = "btnTdelete";
            this.btnTdelete.Size = new System.Drawing.Size(108, 43);
            this.btnTdelete.TabIndex = 7;
            this.btnTdelete.Text = "Delete";
            this.btnTdelete.UseVisualStyleBackColor = true;
            this.btnTdelete.Click += new System.EventHandler(this.BtnTdelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(285, 527);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(108, 43);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(565, 606);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(250, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "See Teachers with groups..";
            // 
            // btnshoww
            // 
            this.btnshoww.Location = new System.Drawing.Point(841, 606);
            this.btnshoww.Name = "btnshoww";
            this.btnshoww.Size = new System.Drawing.Size(75, 25);
            this.btnshoww.TabIndex = 9;
            this.btnshoww.Text = "Show";
            this.btnshoww.UseVisualStyleBackColor = true;
            this.btnshoww.Click += new System.EventHandler(this.Btnshoww_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 434);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Salary";
            // 
            // slry
            // 
            this.slry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slry.Location = new System.Drawing.Point(27, 462);
            this.slry.Name = "slry";
            this.slry.Size = new System.Drawing.Size(360, 30);
            this.slry.TabIndex = 5;
            // 
            // Muellimler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1155, 679);
            this.Controls.Add(this.btnshoww);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnTdelete);
            this.Controls.Add(this.btnTsave);
            this.Controls.Add(this.cbSpc);
            this.Controls.Add(this.slry);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSurname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchClient);
            this.Controls.Add(this.btnTsearch);
            this.Controls.Add(this.dvgTeacherss);
            this.Name = "Muellimler";
            this.Text = "Muellimler";
            this.Load += new System.EventHandler(this.Muellimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgTeacherss)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgTeacherss;
        private System.Windows.Forms.Button btnTsearch;
        private System.Windows.Forms.TextBox txtSearchClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.ComboBox cbSpc;
        private System.Windows.Forms.Button btnTsave;
        private System.Windows.Forms.Button btnTdelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnshoww;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Speiality;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox slry;
    }
}