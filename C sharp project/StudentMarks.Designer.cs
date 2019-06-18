namespace C_sharp_project
{
    partial class StudentMarks
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
            this.dvgavrage = new System.Windows.Forms.DataGridView();
            this.idd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.average = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgMarks = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgstudent2 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SSname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ssurname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbg = new System.Windows.Forms.ComboBox();
            this.txtMark = new System.Windows.Forms.TextBox();
            this.btnsserarch2 = new System.Windows.Forms.Button();
            this.btnwrite = new System.Windows.Forms.Button();
            this.cbgr = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgavrage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMarks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgstudent2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgavrage
            // 
            this.dvgavrage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgavrage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgavrage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idd,
            this.Sname,
            this.Surname,
            this.average});
            this.dvgavrage.Location = new System.Drawing.Point(493, 339);
            this.dvgavrage.Name = "dvgavrage";
            this.dvgavrage.RowTemplate.Height = 24;
            this.dvgavrage.Size = new System.Drawing.Size(446, 272);
            this.dvgavrage.TabIndex = 0;
            // 
            // idd
            // 
            this.idd.HeaderText = "ID";
            this.idd.Name = "idd";
            this.idd.ReadOnly = true;
            this.idd.Visible = false;
            // 
            // Sname
            // 
            this.Sname.HeaderText = "Name";
            this.Sname.Name = "Sname";
            this.Sname.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // average
            // 
            this.average.HeaderText = "Student Averagement";
            this.average.Name = "average";
            this.average.ReadOnly = true;
            // 
            // dvgMarks
            // 
            this.dvgMarks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgMarks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgMarks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.StudentID,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dvgMarks.Location = new System.Drawing.Point(493, 48);
            this.dvgMarks.Name = "dvgMarks";
            this.dvgMarks.RowTemplate.Height = 24;
            this.dvgMarks.Size = new System.Drawing.Size(446, 239);
            this.dvgMarks.TabIndex = 0;
            this.dvgMarks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DvgMarks_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "id";
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Task";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Mark";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dvgstudent2
            // 
            this.dvgstudent2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgstudent2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgstudent2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SSname,
            this.Ssurname});
            this.dvgstudent2.EnableHeadersVisualStyles = false;
            this.dvgstudent2.Location = new System.Drawing.Point(26, 137);
            this.dvgstudent2.Name = "dvgstudent2";
            this.dvgstudent2.RowTemplate.Height = 24;
            this.dvgstudent2.Size = new System.Drawing.Size(394, 239);
            this.dvgstudent2.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Column1";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SSname
            // 
            this.SSname.HeaderText = "Name";
            this.SSname.Name = "SSname";
            this.SSname.ReadOnly = true;
            // 
            // Ssurname
            // 
            this.Ssurname.HeaderText = "Surname";
            this.Ssurname.Name = "Ssurname";
            this.Ssurname.ReadOnly = true;
            // 
            // cbg
            // 
            this.cbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbg.FormattingEnabled = true;
            this.cbg.Location = new System.Drawing.Point(26, 437);
            this.cbg.Name = "cbg";
            this.cbg.Size = new System.Drawing.Size(394, 33);
            this.cbg.TabIndex = 2;
            // 
            // txtMark
            // 
            this.txtMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMark.Location = new System.Drawing.Point(26, 511);
            this.txtMark.Name = "txtMark";
            this.txtMark.Size = new System.Drawing.Size(394, 30);
            this.txtMark.TabIndex = 3;
            // 
            // btnsserarch2
            // 
            this.btnsserarch2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsserarch2.Location = new System.Drawing.Point(323, 47);
            this.btnsserarch2.Name = "btnsserarch2";
            this.btnsserarch2.Size = new System.Drawing.Size(97, 33);
            this.btnsserarch2.TabIndex = 4;
            this.btnsserarch2.Text = "Show";
            this.btnsserarch2.UseVisualStyleBackColor = true;
            this.btnsserarch2.Click += new System.EventHandler(this.Btnsserarch2_Click);
            // 
            // btnwrite
            // 
            this.btnwrite.Location = new System.Drawing.Point(291, 573);
            this.btnwrite.Name = "btnwrite";
            this.btnwrite.Size = new System.Drawing.Size(129, 38);
            this.btnwrite.TabIndex = 5;
            this.btnwrite.Text = "Submit";
            this.btnwrite.UseVisualStyleBackColor = true;
            this.btnwrite.Click += new System.EventHandler(this.Btnwrite_Click);
            // 
            // cbgr
            // 
            this.cbgr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgr.FormattingEnabled = true;
            this.cbgr.Location = new System.Drawing.Point(26, 48);
            this.cbgr.Name = "cbgr";
            this.cbgr.Size = new System.Drawing.Size(278, 33);
            this.cbgr.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Group";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Select Student";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dataGridView1.Location = new System.Drawing.Point(493, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 272);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Name";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Surname";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Student Averagement";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 409);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Select Task";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 488);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "enter mark";
            // 
            // StudentMarks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 699);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbgr);
            this.Controls.Add(this.btnwrite);
            this.Controls.Add(this.btnsserarch2);
            this.Controls.Add(this.txtMark);
            this.Controls.Add(this.cbg);
            this.Controls.Add(this.dvgstudent2);
            this.Controls.Add(this.dvgMarks);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dvgavrage);
            this.Name = "StudentMarks";
            this.Text = "StudentMarks";
            this.Activated += new System.EventHandler(this.StudentMarks_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dvgavrage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgMarks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgstudent2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgavrage;
        private System.Windows.Forms.DataGridViewTextBoxColumn idd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn average;
        private System.Windows.Forms.DataGridView dvgMarks;
        private System.Windows.Forms.DataGridView dvgstudent2;
        private System.Windows.Forms.ComboBox cbg;
        private System.Windows.Forms.TextBox txtMark;
        private System.Windows.Forms.Button btnsserarch2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SSname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ssurname;
        private System.Windows.Forms.Button btnwrite;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ComboBox cbgr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}