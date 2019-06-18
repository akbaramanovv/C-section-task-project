namespace C_sharp_project
{
    partial class Teachers_with_groups
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
            this.dvgT = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Groups = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchh = new System.Windows.Forms.TextBox();
            this.Tsearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnshow3 = new System.Windows.Forms.Button();
            this.btnshow2 = new System.Windows.Forms.Button();
            this.btnShow1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgT)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgT
            // 
            this.dvgT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.dvgT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.TName,
            this.Surname,
            this.Groups,
            this.Salary});
            this.dvgT.Location = new System.Drawing.Point(113, 201);
            this.dvgT.Name = "dvgT";
            this.dvgT.RowTemplate.Height = 24;
            this.dvgT.Size = new System.Drawing.Size(545, 344);
            this.dvgT.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // TName
            // 
            this.TName.HeaderText = "Name";
            this.TName.Name = "TName";
            this.TName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Groups
            // 
            this.Groups.HeaderText = "Groups";
            this.Groups.Name = "Groups";
            this.Groups.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // txtSearchh
            // 
            this.txtSearchh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchh.Location = new System.Drawing.Point(113, 38);
            this.txtSearchh.Name = "txtSearchh";
            this.txtSearchh.Size = new System.Drawing.Size(417, 30);
            this.txtSearchh.TabIndex = 1;
            // 
            // Tsearch
            // 
            this.Tsearch.Location = new System.Drawing.Point(549, 38);
            this.Tsearch.Name = "Tsearch";
            this.Tsearch.Size = new System.Drawing.Size(109, 30);
            this.Tsearch.TabIndex = 2;
            this.Tsearch.Text = "Search";
            this.Tsearch.UseVisualStyleBackColor = true;
            this.Tsearch.Click += new System.EventHandler(this.Tsearch_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(546, 100);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 25);
            this.label10.TabIndex = 11;
            this.label10.Text = "Salary > 1500";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(320, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 25);
            this.label9.TabIndex = 12;
            this.label9.Text = "Salary 100-1500";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(108, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salary < 1000";
            // 
            // btnshow3
            // 
            this.btnshow3.Location = new System.Drawing.Point(551, 132);
            this.btnshow3.Name = "btnshow3";
            this.btnshow3.Size = new System.Drawing.Size(107, 37);
            this.btnshow3.TabIndex = 8;
            this.btnshow3.Text = "Show";
            this.btnshow3.UseVisualStyleBackColor = true;
            // 
            // btnshow2
            // 
            this.btnshow2.Location = new System.Drawing.Point(325, 132);
            this.btnshow2.Name = "btnshow2";
            this.btnshow2.Size = new System.Drawing.Size(107, 37);
            this.btnshow2.TabIndex = 9;
            this.btnshow2.Text = "Show";
            this.btnshow2.UseVisualStyleBackColor = true;
            // 
            // btnShow1
            // 
            this.btnShow1.Location = new System.Drawing.Point(113, 138);
            this.btnShow1.Name = "btnShow1";
            this.btnShow1.Size = new System.Drawing.Size(107, 34);
            this.btnShow1.TabIndex = 10;
            this.btnShow1.Text = "Show";
            this.btnShow1.UseVisualStyleBackColor = true;
            // 
            // Teachers_with_groups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 612);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnshow3);
            this.Controls.Add(this.btnshow2);
            this.Controls.Add(this.btnShow1);
            this.Controls.Add(this.Tsearch);
            this.Controls.Add(this.txtSearchh);
            this.Controls.Add(this.dvgT);
            this.Name = "Teachers_with_groups";
            this.Text = "Teachers_with_groups";
            this.Activated += new System.EventHandler(this.Teachers_with_groups_Activated);
            this.Load += new System.EventHandler(this.Teachers_with_groups_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgT;
        private System.Windows.Forms.TextBox txtSearchh;
        private System.Windows.Forms.Button Tsearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Groups;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnshow3;
        private System.Windows.Forms.Button btnshow2;
        private System.Windows.Forms.Button btnShow1;
    }
}