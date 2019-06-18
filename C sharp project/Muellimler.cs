using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using C_sharp_project.Modelss;

namespace C_sharp_project
{   
    
    public partial class Muellimler : Form
    {
       Modelss.Teacher T = new Modelss.Teacher();
        public Muellimler()
        {
            InitializeComponent();
        }
        private void Cancel()
        {
            cbSpc.SelectedItem = 0;
            btnTdelete.Enabled = false;
            btnTsave.Text = "Save";
            txtName.Text = txtSurname.Text = cbSpc.Text = txtEmail.Text = txtPhone.Text = slry.Text = "";
        }
        private void FillTeachers()
        {
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Teacher> teachers = db.Teachers.Where(t=>t.Status == true).ToList();
                List<Modelss.Group> grps = db.Groups.Where(g => g.Status == true).ToList();
                foreach (var item in teachers)
                {
                   
                  var list = db.Groups.Where(g => g.TeacherId == item.Id).ToList();

                    string Tgroups = " ";
                    foreach (var item2 in list)
                    {
                        Tgroups += item2.Name + "  ";
                    }
                    dvgTeacherss.Rows.Add(item.Id, item.Name, item.Surname, item.Education.Name, item.Email, item.Phone , item.Salary);
                }
                List<Modelss.Education> educations = db.Educations.ToList();
                List<Modelss.Group> gr = db.Groups.ToList();
               
                foreach (var item in educations)
                {
                   
                    cbSpc.Items.Add(item.Name);
                }
            }
        }
        private void Muellimler_Load(object sender, EventArgs e)
        {
             FillTeachers();
            btnTdelete.Enabled = false;
        }
        private void Refresh()
        {
            dvgTeacherss.Rows.Clear();
            FillTeachers();
            btnTdelete.Enabled = false;
            btnTsave.Text = "Save";
            txtName.Text = txtSurname.Text = cbSpc.Text = txtEmail.Text = txtPhone.Text = "";
        }
        private void BtnTsave_Click(object sender, EventArgs e)
        {
            if (btnTdelete.Enabled)
            {
                if (!UpdateTeacher())
                {
                    MessageBox.Show("Not Submited");
                    return;
                }
                MessageBox.Show("Submited");
                Refresh();
               
                return;
            }

            int affectedRow = 0;
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Education> spcs = db.Educations.Where(a => a.Status == true).ToList();
                List<Modelss.Teacher> teachers = db.Teachers.Where(t => t.Status == true).ToList();

                Modelss.Teacher tt = new Modelss.Teacher();


                //validation Name
                string onlyLetters = @"^[a-zA-Z]+$";
                Regex tname = new Regex(onlyLetters);
                Match tnameMatch = tname.Match(txtName.Text);
                if (!tnameMatch.Success)
                {
                    MessageBox.Show("Adi duzgun Daxil edin");
                    txtName.Text = "";
                    return;
                }

                //validation Surname
                Regex tsurname = new Regex(onlyLetters);
                Match tsurnameMatch = tsurname.Match(txtSurname.Text);
                if (!tsurnameMatch.Success)
                {
                    MessageBox.Show("Soyadi duzgun Daxil edin");
                    txtSurname.Text = "";
                    return;
                }
                string emailPattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

                //email validation
                Regex mail = new Regex(emailPattern);
                Match mailMatch = mail.Match(txtEmail.Text);
                if (!mailMatch.Success)
                {
                    MessageBox.Show("Emaili duzgin daxil edin...");
                    txtEmail.Text = "";
                    return;
                }
                //validation only numbers
                String patternnum = "^[0-9]+(,[0-9]+)*$";
                Regex salry = new Regex(patternnum);
                Match numMatch = salry.Match(slry.Text);
                if (!numMatch.Success)
                {
                    MessageBox.Show("Yalniz ededler daxil edin");
                    slry.Text = "";
                    return;
                }

                dvgTeacherss.Rows.Add(ID, txtName.Text, txtSurname.Text, cbSpc.Text, txtEmail.Text, txtPhone.Text);

               
                tt.Name = txtName.Text;
                tt.Surname = txtSurname.Text;

                int selected = cbSpc.SelectedIndex;
                List<Modelss.Education> educations = db.Educations.ToList();
                int catID = educations[selected].Id;

                tt.SpecialityID = catID;

                tt.Email = txtEmail.Text;

                tt.Phone = txtPhone.Text;
                tt.Salary = Convert.ToDouble(slry.Text);
                tt.Status = true;
                db.Teachers.Add(tt);
                txtName.Text = txtSurname.Text = cbSpc.Text = txtEmail.Text = txtPhone.Text =slry.Text = "";
                affectedRow = db.SaveChanges();
                if (affectedRow>0)
                {
                    MessageBox.Show("Melumat qeyde alindi");
                }
                else
                {
                    MessageBox.Show("xeta!!");
                }

            }
        }
       
        private void BtnTsearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchClient.Text.Trim().ToLower();
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Teacher> Tlist = db.Teachers.Where(c => c.Name.ToLower().Contains(searchText)||
                 c.Surname.ToLower().Contains(searchText)||
                 c.Email.ToLower().Contains(searchText)||
                 c.Phone.ToLower().Contains(searchText)
                ).ToList();

                dvgTeacherss.Rows.Clear();
                foreach (var item in Tlist)
                {
                    dvgTeacherss.Rows.Add(item.Id, item.Name, item.Surname, item.Education.Name, item.Email, item.Phone );
                }
            }
        }

        private void DvgTeacherss_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnTdelete.Enabled = true;
            btnTsave.Text = "Update";
            txtName.Text = dvgTeacherss.CurrentRow.Cells[1].Value.ToString();
            txtSurname.Text = dvgTeacherss.CurrentRow.Cells[2].Value.ToString();
            cbSpc.Text = dvgTeacherss.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dvgTeacherss.CurrentRow.Cells[4].Value.ToString();
            txtPhone.Text = dvgTeacherss.CurrentRow.Cells[5].Value.ToString();
        }

        private bool UpdateTeacher()
        {
            int affectedRows = 0;
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                int spId = (db.Educations.Where(a => a.Name == cbSpc.SelectedItem.ToString())).FirstOrDefault().Id;

                T.Id = Convert.ToInt32(dvgTeacherss.CurrentRow.Cells[0].Value);
                Modelss.Teacher Teachers = db.Teachers.Where(g =>g.Id == T.Id).FirstOrDefault();

                Teachers.Name = txtName.Text;
                Teachers.Surname = txtSurname.Text;
                Teachers.Email = txtEmail.Text;
                Teachers.Phone = txtPhone.Text;
                Teachers.SpecialityID = spId;

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

        private bool DeleteTeacher()
        {
            int affectedRows = 0;

            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                T.Id = Convert.ToInt32(dvgTeacherss.CurrentRow.Cells[0].Value);
                Modelss.Teacher Teachers = db.Teachers.Where(g => g.Id == T.Id).FirstOrDefault();

                db.Teachers.Remove(Teachers);

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

        private void BtnTdelete_Click(object sender, EventArgs e)
        {
            var message = MessageBox.Show(T.Name + " " + T.Surname + " Are you sure", "Delete", MessageBoxButtons.YesNo);

            if (DialogResult.Yes!= message)
            {
                return;
            }
            if (!DeleteTeacher())
            {
                MessageBox.Show("Not deleted !!!");
            }

            MessageBox.Show("Deleted");
            Refresh();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void Btnshoww_Click(object sender, EventArgs e)
        {
            Teachers_with_groups s = new Teachers_with_groups();
            s.ShowDialog();
        }
    }
}
