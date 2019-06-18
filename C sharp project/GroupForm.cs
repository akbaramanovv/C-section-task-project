using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace C_sharp_project
{
    public partial class GroupForm : Form
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void GroupForm_Activated(object sender, EventArgs e)
        {
            dvggroup.Rows.Clear();
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Group> grps = db.Groups.ToList();
                foreach (var item in grps)
                {
                    string mname = db.Employees.Where(m => m.Id == item.MentorId).FirstOrDefault().Name;
                    var list = db.Teachers.Where(t => t.Id == item.TeacherId).ToList();
                    string tname = "";
                    foreach (var item2 in list)
                    {
                        tname += item2.Name;
                    }

                    dvggroup.Rows.Add(item.Id, item.Name, tname, mname, item.Education.Name, item.Capacity, item.Classroom.Name);
                   
                   
                }
                List<Modelss.Employee> emp = db.Employees.Where(em=>em.PositionId == 1).ToList();
                cbmentor.Items.Clear();
                foreach (var item in emp)
                {
                    cbmentor.Items.Add(item.Name);
                }
                List<Modelss.Teacher> tch = db.Teachers.ToList();
                cbteacher.Items.Clear();
                foreach (var item in tch)
                {
                    cbteacher.Items.Add(item.Name);
                }
                List<Modelss.Education> edc = db.Educations.ToList();
                cbprogram.Items.Clear();
                foreach (var item in edc)
                {
                    cbprogram.Items.Add(item.Name);
                }
                List<Modelss.Classroom> rooms = db.Classrooms.ToList();
                cbroom.Items.Clear();
                foreach (var item in rooms)
                {
                    cbroom.Items.Add(item.Name);
                }
            }
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {

        }
    }
}
