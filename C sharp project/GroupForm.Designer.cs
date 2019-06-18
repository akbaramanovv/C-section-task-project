namespace C_sharp_project
{
    partial class GroupForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbroom = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbteacher = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbmentor = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbprogram = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcapacity = new System.Windows.Forms.TextBox();
            this.dvggroup = new System.Windows.Forms.DataGridView();
            this.GRid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvggroup)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(42, 63);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(330, 30);
            this.txtname.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clasrooms";
            // 
            // cbroom
            // 
            this.cbroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbroom.FormattingEnabled = true;
            this.cbroom.Location = new System.Drawing.Point(42, 145);
            this.cbroom.Name = "cbroom";
            this.cbroom.Size = new System.Drawing.Size(330, 33);
            this.cbroom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Teacher";
            // 
            // cbteacher
            // 
            this.cbteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbteacher.FormattingEnabled = true;
            this.cbteacher.Location = new System.Drawing.Point(42, 228);
            this.cbteacher.Name = "cbteacher";
            this.cbteacher.Size = new System.Drawing.Size(330, 33);
            this.cbteacher.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 279);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mentor";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cbmentor
            // 
            this.cbmentor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbmentor.FormattingEnabled = true;
            this.cbmentor.Location = new System.Drawing.Point(42, 308);
            this.cbmentor.Name = "cbmentor";
            this.cbmentor.Size = new System.Drawing.Size(330, 33);
            this.cbmentor.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Education";
            this.label5.Click += new System.EventHandler(this.Label4_Click);
            // 
            // cbprogram
            // 
            this.cbprogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbprogram.FormattingEnabled = true;
            this.cbprogram.Location = new System.Drawing.Point(42, 393);
            this.cbprogram.Name = "cbprogram";
            this.cbprogram.Size = new System.Drawing.Size(330, 33);
            this.cbprogram.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(37, 447);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Capacity";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // txtcapacity
            // 
            this.txtcapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcapacity.Location = new System.Drawing.Point(42, 475);
            this.txtcapacity.Name = "txtcapacity";
            this.txtcapacity.Size = new System.Drawing.Size(330, 30);
            this.txtcapacity.TabIndex = 1;
            this.txtcapacity.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // dvggroup
            // 
            this.dvggroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvggroup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GRid,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dvggroup.Location = new System.Drawing.Point(417, 63);
            this.dvggroup.Name = "dvggroup";
            this.dvggroup.RowTemplate.Height = 24;
            this.dvggroup.Size = new System.Drawing.Size(562, 490);
            this.dvggroup.TabIndex = 3;
            // 
            // GRid
            // 
            this.GRid.HeaderText = "id";
            this.GRid.Name = "GRid";
            this.GRid.ReadOnly = true;
            this.GRid.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Teacher";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mentor";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Program";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Capacity";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Room";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 666);
            this.Controls.Add(this.dvggroup);
            this.Controls.Add(this.cbprogram);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbmentor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbteacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbroom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcapacity);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Activated += new System.EventHandler(this.GroupForm_Activated);
            this.Load += new System.EventHandler(this.GroupForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvggroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbteacher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbmentor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbprogram;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcapacity;
        private System.Windows.Forms.DataGridView dvggroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn GRid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}