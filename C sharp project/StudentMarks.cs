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
    public partial class StudentMarks : Form
    {
        Modelss.StudentsMark studentMark = new Modelss.StudentsMark();
        public StudentMarks()
        {
            InitializeComponent();
        }

        void FilldvgAverage()
        {
            dvgavrage.Rows.Clear();
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Student> student = db.Students.ToList();
                foreach (var item in student)
                {

                    var tasklist = db.StudentsMarks.Where(m => m.StudentId == item.Id).ToList();

                    int mark = 0;
                    int average = 0;
                    foreach (var item2 in tasklist)
                    {

                        mark += item2.Mark ;
                         average = mark / tasklist.Count;
                    }

                    dvgavrage.Rows.Add(item.Id, item.Name, item.Surname, average);

                }
            }
        }
       
        void FilldvgMarks()
        {

            dvgMarks.Rows.Clear();
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.StudentsMark> studentsmark = db.StudentsMarks.ToList();
               
                foreach (var item in studentsmark)
                {

                    var studentList = db.Students.Where(m => m.Id == item.StudentId).ToList();

                    foreach (var item2 in studentList)
                    {

                        dvgMarks.Rows.Add(item.Id,item2.Id, item2.Name, item2.Surname, item.Task.Name, item.Mark);

                    }
                  

                }
            }
        }

        private void StudentMarks_Activated(object sender, EventArgs e)
        {
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Task> tasks = db.Tasks.ToList();
                cbg.Items.Clear();
                foreach (var item in tasks)
                {
                    cbg.Items.Add(item.Name);
                }
                List<Modelss.Group> groups = db.Groups.ToList();
                foreach (var item in groups)
                {
                    cbgr.Items.Add(item.Name);
                }
            }
           
            FilldvgMarks();

            FilldvgAverage();
           
        }

        void FillStudents()
        {
            dvgstudent2.Rows.Clear();
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {


                List<Modelss.Student> students = db.Students.Where(s=>s.Group.Name == cbgr.Text).ToList();

                foreach (var item in students)
                {
                   
                    dvgstudent2.Rows.Add(item.Id, item.Name, item.Surname);
                    
                }
                  

                   
                
            }
        }

        private void Btnwrite_Click(object sender, EventArgs e)
        {
            if (btnwrite.Text == "Update")
            {
                if (!UpdateMark())
                {
                    MessageBox.Show("Not Submitted");
                    cbg.Text = txtMark.Text = "";
                    
                    return;
                }
                MessageBox.Show("Submitted");
                FilldvgMarks();

                FilldvgAverage();
                btnwrite.Text = "Submit";
                cbg.Text = txtMark.Text = "";
                return;
            }
          
            string sname = dvgstudent2.CurrentRow.Cells[1].Value.ToString();
            string ssurname = dvgstudent2.CurrentRow.Cells[2].Value.ToString();
            int id = Convert.ToInt32(dvgstudent2.CurrentRow.Cells[0].Value);
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                Modelss.StudentsMark sm = new Modelss.StudentsMark();
                int taskid = Convert.ToInt32(db.Tasks.Where(t => t.Name == cbg.Text).FirstOrDefault().Id);
              
                sm.Mark = Convert.ToInt32(txtMark.Text);

                sm.StudentId = id;
                sm.TaskId = taskid;
                db.StudentsMarks.Add(sm);
                db.SaveChanges();
            }
            FilldvgMarks();

            FilldvgAverage();
            txtMark.Text = cbg.Text = " ";
        }

        private void DvgMarks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnwrite.Text = "Update";
            txtMark.Text = dvgMarks.CurrentRow.Cells[5].Value.ToString();
            cbg.Text = dvgMarks.CurrentRow.Cells[4].Value.ToString();
        }

       private bool UpdateMark()
        {
            int affectedRows = 0;
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                studentMark.StudentId = Convert.ToInt32(dvgMarks.CurrentRow.Cells[1].Value);
                Modelss.StudentsMark studenmarks = db.StudentsMarks.Where(m => m.StudentId == studentMark.StudentId).FirstOrDefault();
                int taskid = Convert.ToInt32(db.Tasks.Where(t => t.Name == cbg.Text).FirstOrDefault().Id);
                studenmarks.Mark = Convert.ToInt32(txtMark.Text);
                studenmarks.TaskId = taskid;
                studenmarks.StudentId = Convert.ToInt32(dvgMarks.CurrentRow.Cells[1].Value);

                 affectedRows =  db.SaveChanges();
            }
            if (affectedRows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Btnsserarch2_Click(object sender, EventArgs e)
        {
            FillStudents();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
    }
}
