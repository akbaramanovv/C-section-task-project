using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {
            Muellimler m = new Muellimler();
            m.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            EmployeeForm emp = new EmployeeForm();
            emp.ShowDialog();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            StudentForm ss = new StudentForm();
            ss.ShowDialog();
        }

        private void Btntasks_Click(object sender, EventArgs e)
        {
            TaskForm tf = new TaskForm();
            tf.ShowDialog();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            GroupForm gf = new GroupForm();
            gf.ShowDialog();
        }
    }
}
