namespace C_sharp_project
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
            this.btnTeacheer = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btntasks = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTeacheer
            // 
            this.btnTeacheer.BackColor = System.Drawing.Color.SpringGreen;
            this.btnTeacheer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacheer.Location = new System.Drawing.Point(93, 58);
            this.btnTeacheer.Name = "btnTeacheer";
            this.btnTeacheer.Size = new System.Drawing.Size(359, 235);
            this.btnTeacheer.TabIndex = 0;
            this.btnTeacheer.Text = "Teachers";
            this.btnTeacheer.UseVisualStyleBackColor = false;
            this.btnTeacheer.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Highlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(499, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(403, 235);
            this.button2.TabIndex = 0;
            this.button2.Text = "Students";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(93, 340);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(359, 235);
            this.button3.TabIndex = 0;
            this.button3.Text = "Employees";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(933, 340);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(387, 235);
            this.button4.TabIndex = 1;
            this.button4.Text = "Programs";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Yellow;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(933, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(387, 235);
            this.button5.TabIndex = 2;
            this.button5.Text = "Groups";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // btntasks
            // 
            this.btntasks.BackColor = System.Drawing.Color.Olive;
            this.btntasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntasks.Location = new System.Drawing.Point(499, 340);
            this.btntasks.Name = "btntasks";
            this.btntasks.Size = new System.Drawing.Size(403, 235);
            this.btntasks.TabIndex = 3;
            this.btntasks.Text = "Tasks";
            this.btntasks.UseVisualStyleBackColor = false;
            this.btntasks.Click += new System.EventHandler(this.Btntasks_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1377, 636);
            this.Controls.Add(this.btntasks);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnTeacheer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTeacheer;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btntasks;
    }
}

