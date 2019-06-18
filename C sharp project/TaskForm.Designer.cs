namespace C_sharp_project
{
    partial class TaskForm
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
            this.cbgroups = new System.Windows.Forms.ComboBox();
            this.cbGr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTask = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tdedline = new System.Windows.Forms.DateTimePicker();
            this.btnSCancel = new System.Windows.Forms.Button();
            this.btnSdelete = new System.Windows.Forms.Button();
            this.btnSTsave = new System.Windows.Forms.Button();
            this.dvgtask = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dedline = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stshow = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgtask)).BeginInit();
            this.SuspendLayout();
            // 
            // cbgroups
            // 
            this.cbgroups.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbgroups.FormattingEnabled = true;
            this.cbgroups.Location = new System.Drawing.Point(31, 210);
            this.cbgroups.Name = "cbgroups";
            this.cbgroups.Size = new System.Drawing.Size(368, 33);
            this.cbgroups.TabIndex = 27;
            // 
            // cbGr
            // 
            this.cbGr.AutoSize = true;
            this.cbGr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGr.Location = new System.Drawing.Point(26, 182);
            this.cbGr.Name = "cbGr";
            this.cbGr.Size = new System.Drawing.Size(76, 25);
            this.cbGr.TabIndex = 21;
            this.cbGr.Text = "Groups";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 25);
            this.label2.TabIndex = 22;
            this.label2.Text = "Dedline";
            // 
            // txtTask
            // 
            this.txtTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTask.Location = new System.Drawing.Point(31, 54);
            this.txtTask.Name = "txtTask";
            this.txtTask.Size = new System.Drawing.Size(368, 30);
            this.txtTask.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "Name";
            // 
            // tdedline
            // 
            this.tdedline.CustomFormat = "yyyy-MM-dd";
            this.tdedline.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdedline.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.tdedline.Location = new System.Drawing.Point(31, 134);
            this.tdedline.Name = "tdedline";
            this.tdedline.Size = new System.Drawing.Size(368, 30);
            this.tdedline.TabIndex = 28;
            // 
            // btnSCancel
            // 
            this.btnSCancel.Location = new System.Drawing.Point(291, 279);
            this.btnSCancel.Name = "btnSCancel";
            this.btnSCancel.Size = new System.Drawing.Size(108, 43);
            this.btnSCancel.TabIndex = 29;
            this.btnSCancel.Text = "Cancel";
            this.btnSCancel.UseVisualStyleBackColor = true;
            // 
            // btnSdelete
            // 
            this.btnSdelete.Location = new System.Drawing.Point(163, 279);
            this.btnSdelete.Name = "btnSdelete";
            this.btnSdelete.Size = new System.Drawing.Size(108, 43);
            this.btnSdelete.TabIndex = 30;
            this.btnSdelete.Text = "Delete";
            this.btnSdelete.UseVisualStyleBackColor = true;
            // 
            // btnSTsave
            // 
            this.btnSTsave.Location = new System.Drawing.Point(31, 279);
            this.btnSTsave.Name = "btnSTsave";
            this.btnSTsave.Size = new System.Drawing.Size(108, 43);
            this.btnSTsave.TabIndex = 31;
            this.btnSTsave.Text = "Save";
            this.btnSTsave.UseVisualStyleBackColor = true;
            this.btnSTsave.Click += new System.EventHandler(this.BtnSTsave_Click);
            // 
            // dvgtask
            // 
            this.dvgtask.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgtask.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgtask.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.groupID,
            this.TaskName,
            this.Dedline,
            this.Group});
            this.dvgtask.Location = new System.Drawing.Point(514, 54);
            this.dvgtask.Name = "dvgtask";
            this.dvgtask.RowTemplate.Height = 24;
            this.dvgtask.Size = new System.Drawing.Size(523, 189);
            this.dvgtask.TabIndex = 32;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // groupID
            // 
            this.groupID.HeaderText = "Group id";
            this.groupID.Name = "groupID";
            this.groupID.ReadOnly = true;
            this.groupID.Visible = false;
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Name";
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // Dedline
            // 
            this.Dedline.HeaderText = "Dedline";
            this.Dedline.Name = "Dedline";
            this.Dedline.ReadOnly = true;
            // 
            // Group
            // 
            this.Group.HeaderText = "Group";
            this.Group.Name = "Group";
            this.Group.ReadOnly = true;
            // 
            // stshow
            // 
            this.stshow.Location = new System.Drawing.Point(514, 279);
            this.stshow.Name = "stshow";
            this.stshow.Size = new System.Drawing.Size(523, 40);
            this.stshow.TabIndex = 33;
            this.stshow.Text = "Show";
            this.stshow.UseVisualStyleBackColor = true;
            this.stshow.Click += new System.EventHandler(this.Stshow_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 20);
            this.label3.TabIndex = 34;
            this.label3.Text = "Select group from dvg";
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 615);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.stshow);
            this.Controls.Add(this.dvgtask);
            this.Controls.Add(this.btnSCancel);
            this.Controls.Add(this.btnSdelete);
            this.Controls.Add(this.btnSTsave);
            this.Controls.Add(this.tdedline);
            this.Controls.Add(this.cbgroups);
            this.Controls.Add(this.cbGr);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTask);
            this.Controls.Add(this.label1);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.Activated += new System.EventHandler(this.TaskForm_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.dvgtask)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbgroups;
        private System.Windows.Forms.Label cbGr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTask;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tdedline;
        private System.Windows.Forms.Button btnSCancel;
        private System.Windows.Forms.Button btnSdelete;
        private System.Windows.Forms.Button btnSTsave;
        private System.Windows.Forms.DataGridView dvgtask;
        private System.Windows.Forms.Button stshow;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn groupID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dedline;
        private System.Windows.Forms.DataGridViewTextBoxColumn Group;
        private System.Windows.Forms.Label label3;
    }
}