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
    public partial class Teachers_with_groups : Form
    {
        public Teachers_with_groups()
        {
            InitializeComponent();
        }

        private void Teachers_with_groups_Load(object sender, EventArgs e)
        {
           
           
        }

        private void Teachers_with_groups_Activated(object sender, EventArgs e)
        {
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Group> gr = db.Groups.ToList();
                List<Modelss.Teacher> teachers = db.Teachers.ToList();
                foreach (var item in teachers)
                {
                    var list = db.Groups.Where(g => g.TeacherId == item.Id).ToList();

                    string Tgroups = " ";
                    foreach (var item2 in list)
                    {
                        Tgroups += item2.Name + "  ";
                    }
                    dvgT.Rows.Add(item.Id,item.Name, item.Surname, Tgroups ,  item.Salary );
                }

            }

        }

        private void Tsearch_Click(object sender, EventArgs e)
        {
            string srctxt = txtSearchh.Text.Trim().ToLower();
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Group> gr = db.Groups.ToList();
               
                List<Modelss.Teacher> tch = db.Teachers.Where(t => t.Name.ToLower().Contains(srctxt) ||
                t.Surname.ToLower().Contains(srctxt)||
                t.Salary.ToString().Contains(srctxt)
                ).ToList();
                dvgT.Rows.Clear();
                foreach (var item in tch)
                {
                    var list = db.Groups.Where(g => g.TeacherId == item.Id).ToList();

                    string Tgroups = " ";
                    foreach (var item2 in list)
                    {
                        Tgroups += item2.Name + "  ";
                    }
                    dvgT.Rows.Add(item.Id, item.Name, item.Surname, Tgroups, item.Salary);
                }
            }
        }
    }
}
