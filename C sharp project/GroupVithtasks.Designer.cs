namespace C_sharp_project
{
    partial class GroupVithtasks
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
            this.dvgsmark2 = new System.Windows.Forms.DataGridView();
            this.txtmark = new System.Windows.Forms.TextBox();
            this.btnmark2 = new System.Windows.Forms.Button();
            this.Tid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tidd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgsmark2)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgsmark2
            // 
            this.dvgsmark2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgsmark2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgsmark2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.tidd,
            this.snameee,
            this.Column1,
            this.Column2,
            this.Column3});
            this.dvgsmark2.Location = new System.Drawing.Point(565, 61);
            this.dvgsmark2.Name = "dvgsmark2";
            this.dvgsmark2.RowTemplate.Height = 24;
            this.dvgsmark2.Size = new System.Drawing.Size(455, 398);
            this.dvgsmark2.TabIndex = 2;
            this.dvgsmark2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvgsmark2_CellDoubleClick);
            // 
            // txtmark
            // 
            this.txtmark.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmark.Location = new System.Drawing.Point(29, 61);
            this.txtmark.Name = "txtmark";
            this.txtmark.Size = new System.Drawing.Size(323, 30);
            this.txtmark.TabIndex = 3;
            // 
            // btnmark2
            // 
            this.btnmark2.Location = new System.Drawing.Point(29, 139);
            this.btnmark2.Name = "btnmark2";
            this.btnmark2.Size = new System.Drawing.Size(106, 41);
            this.btnmark2.TabIndex = 4;
            this.btnmark2.Text = "Save";
            this.btnmark2.UseVisualStyleBackColor = true;
            this.btnmark2.Click += new System.EventHandler(this.Btnmark2_Click);
            // 
            // Tid
            // 
            this.Tid.HeaderText = "id";
            this.Tid.Name = "Tid";
            this.Tid.Visible = false;
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
            this.SName.Width = 103;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Surname";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            this.Surname.Width = 103;
            // 
            // sid
            // 
            this.sid.HeaderText = "id";
            this.sid.Name = "sid";
            this.sid.Visible = false;
            // 
            // tidd
            // 
            this.tidd.HeaderText = "id";
            this.tidd.Name = "tidd";
            this.tidd.Visible = false;
            // 
            // snameee
            // 
            this.snameee.HeaderText = "Name";
            this.snameee.Name = "snameee";
            this.snameee.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Surname";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Task";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mark";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // GroupVithtasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 527);
            this.Controls.Add(this.btnmark2);
            this.Controls.Add(this.txtmark);
            this.Controls.Add(this.dvgsmark2);
            this.Name = "GroupVithtasks";
            this.Text = "GroupVithtasks";
            this.Load += new System.EventHandler(this.GroupVithtasks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgsmark2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dvgsmark2;
        private System.Windows.Forms.TextBox txtmark;
        private System.Windows.Forms.Button btnmark2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn tidd;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}