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
    public partial class StudentForm : Form
    {
        Modelss.Student studentFounded = new Modelss.Student();
        public StudentForm()
        {
            InitializeComponent();
        }
        void FillStudents()
        {

            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                dvgstudent.Rows.Clear();
                List<Modelss.Student> students = db.Students.Where(s=> s.Status ==true).ToList();
                List<Modelss.Group> grps = db.Groups.Where(g=> g.Status == true).ToList();
                foreach (var item in grps)
                {
                    cbStudentGroups.Items.Add(item.Name);
                }

                foreach (var item in students)
                {
                    List<Modelss.Group> groups = db.Groups.Where(g => g.Id == item.GroupId).ToList();
                    double studentGroup = 0;
                    foreach (var item2 in groups)
                    {
                        studentGroup = Convert.ToDouble(item2.Education.Price);

                    }
                    double odm = studentGroup - Convert.ToDouble(item.Fee);
                    if (odm < 0)
                    {
                        odm = 0;

                    }
                    dvgstudent.Rows.Add(item.Id, item.Name, item.Surname, item.Email, item.Phone, item.Group.Name, item.Fee, odm);
                }
            }
        }
        private void StudentForm_Activated(object sender, EventArgs e)
        {
            dvgstudent.Rows.Clear();
            btnSdelete.Enabled = false;
            FillStudents();
        }
        void Refresh()
        {
            dvgstudent.Rows.Clear();
            FillStudents();
            txtSName.Text = txtSSurname.Text = txtSEmail.Text = cbStudentGroups.Text = TxtSFee.Text = txtSPhone.Text = " ";
            btnSdelete.Enabled = false;
            btnSTsave.Text = "Save";
        }
        private void BtnSTsave_Click(object sender, EventArgs e)
        {
            if (btnSdelete.Enabled)
            {
                if (!UpdateStudent())
                {
                    MessageBox.Show(" Not Submited");
                    return;
                }
                MessageBox.Show("  Submited");
                Refresh();


                return;
            }
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {

                Modelss.Student students = new Modelss.Student();
                List<Modelss.Group> gr = db.Groups.ToList();
                int selected = cbStudentGroups.SelectedIndex;
                int StudentGrId = gr[selected].Id;
                List<Modelss.Student> studentss = db.Students.ToList();

                dvgstudent.Rows.Add(ID, txtSName.Text, txtSSurname.Text, txtSEmail.Text, txtSPhone.Text, cbStudentGroups.Text, TxtSFee.Text);

                students.Name = txtSName.Text;
                students.Surname = txtSSurname.Text;
                students.Email = txtSEmail.Text;
                students.GroupId = StudentGrId;
                students.Phone = txtSPhone.Text;
                students.Fee = Convert.ToDouble(TxtSFee.Text);
                students.Status = true;


                txtSName.Text = txtSSurname.Text = txtSEmail.Text = cbStudentGroups.Text = TxtSFee.Text = txtSPhone.Text = " ";
                db.Students.Add(students);
                db.SaveChanges();
            }
        }

        private bool UpdateStudent()
        {
            int affectedRows = 0;
            using (Modelss.AKADEMIYAEntities2 db  = new Modelss.AKADEMIYAEntities2())
            {
                studentFounded.Id = Convert.ToInt32(dvgstudent.CurrentRow.Cells[0].Value);
                List<Modelss.Group> gr = db.Groups.Where(g=> g.Status ==true).ToList();
                int selected = cbStudentGroups.SelectedIndex;
                int grId = gr[selected].Id;
                Modelss.Student student = db.Students.Where(s => s.Id == studentFounded.Id).FirstOrDefault();
                student.Name = txtSName.Text;
                student.Surname = txtSSurname.Text;
                student.Email = txtSEmail.Text;
                student.GroupId = grId;
                student.Phone = txtSPhone.Text;
                student.Fee = Convert.ToDouble(TxtSFee.Text);
                student.Status = true;

                affectedRows = db.SaveChanges();
               
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

        private bool DeleteStudent()
        {
            int affectedRows = 0;
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                studentFounded.Id = Convert.ToInt32(dvgstudent.CurrentRow.Cells[0].Value);
                Modelss.Student st = db.Students.Where(s => s.Id == studentFounded.Id).FirstOrDefault();
                db.Students.Remove(st);

                affectedRows = db.SaveChanges();

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
        private void Dvgstudent_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSdelete.Enabled = true;
            btnSTsave.Text = "Update";
            txtSPhone.Text = cbStudentGroups.Text = dvgstudent.CurrentRow.Cells[4].Value.ToString();

            txtSName.Text = dvgstudent.CurrentRow.Cells[1].Value.ToString();
            txtSSurname.Text = dvgstudent.CurrentRow.Cells[2].Value.ToString();
            txtSEmail.Text = dvgstudent.CurrentRow.Cells[3].Value.ToString();
            cbStudentGroups.Text = dvgstudent.CurrentRow.Cells[5].Value.ToString();
            TxtSFee.Text = dvgstudent.CurrentRow.Cells[6].Value.ToString();
        }

        void Cancel()
        {
            cbStudentGroups.SelectedItem = 0;
            txtSName.Text = txtSSurname.Text = txtSEmail.Text = cbStudentGroups.Text = TxtSFee.Text = txtSPhone.Text = " ";
            btnSdelete.Enabled = false;
            btnSTsave.Text = "Save";
            
        }
        private void BtnSdelete_Click(object sender, EventArgs e)
        {
            if (btnSdelete.Enabled)
            {
                if (!DeleteStudent())
                {
                    MessageBox.Show("Not Submitted!");
                    return;
                }
                MessageBox.Show("Submitted");
                Refresh();
                FillStudents();
                return;
            }
        }

        private void BtnSCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void BtnSsearch_Click(object sender, EventArgs e)
        {
            string srchTxt = txtSearchstudent.Text.Trim().ToLower();
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Student> foundedStudents = db.Students.Where(f => f.Name.ToLower().Contains(srchTxt) ||
                f.Surname.ToLower().Contains(srchTxt) ||
                f.Group.Name.ToLower().Contains(srchTxt) ||
                f.Phone.ToLower().Contains(srchTxt) ||
                f.Email.ToLower().Contains(srchTxt)
                ).ToList();

                dvgstudent.Rows.Clear();
                foreach (var item in foundedStudents)
                {
                    List<Modelss.Group> groups = db.Groups.Where(g => g.Id == item.GroupId).ToList();
                    double studentGroup = 0;
                    foreach (var item2 in groups)
                    {
                        studentGroup = Convert.ToDouble(item2.Education.Price);

                    }
                    double odm = studentGroup - Convert.ToDouble(item.Fee);
                    if (odm < 0)
                    {
                        odm = 0;

                    }
                    dvgstudent.Rows.Add(item.Id , item.Name , item.Surname, item.Email, item.Phone, item.Group.Name ,item.Fee ,odm);
                }
            }
        }

        private void Btnshow_Click(object sender, EventArgs e)
        {
            StudentMarks d = new StudentMarks();
            d.ShowDialog();
        }
    }
}
