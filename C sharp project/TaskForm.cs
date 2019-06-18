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

    public partial class TaskForm : Form
    {
   
        Modelss.Group groupp = new Modelss.Group();
   
        public TaskForm()
        {
            InitializeComponent();

        }

        private void TaskForm_Activated(object sender, EventArgs e)
        {
            dvgtask.Rows.Clear();
            cbgroups.Items.Clear();
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Modelss.Group> gr = db.Groups.ToList();
                foreach (var item in gr)
                {
                    cbgroups.Items.Add(item.Name);
                }
                List<Modelss.Task> tasks = db.Tasks.ToList();
                foreach (var item in tasks)
                {
                    dvgtask.Rows.Add(item.GroupId, item.Id, item.Name, item.Deadline, item.Group.Name);
                }
            }
        }


        private void BtnSTsave_Click(object sender, EventArgs e)
        {
            int affectedRows = 0;
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {


                groupp.Id = db.Groups.Where(g => g.Name == cbgroups.Text).FirstOrDefault().Id;
             

               
                //db.Tasks.Where(t => t.GroupId == groupp.Id).FirstOrDefault();
                Modelss.Task grpTask = new Modelss.Task();

                grpTask.Name = txtTask.Text;
                grpTask.Deadline = Convert.ToDateTime(tdedline.Text);
                grpTask.GroupId = groupp.Id;
                grpTask.Status = true;
                db.Tasks.Add(grpTask);
                
                affectedRows = db.SaveChanges();
                txtTask.Text = tdedline.Text = cbgroups.Text = "";
                
               
            }
            if (affectedRows > 0)
                {
                    MessageBox.Show("Submitted");
                    return;
                }
                else
                {
                    MessageBox.Show("Not Submitted !!");
                    return;
                }
            

        }
        private void Stshow_Click(object sender, EventArgs e)
        {
            int groupid = Convert.ToInt32(dvgtask.CurrentRow.Cells[0].Value);
            int taskid = Convert.ToInt32(dvgtask.CurrentRow.Cells[1].Value);

            GroupVithtasks rt = new GroupVithtasks(taskid, groupid);
            rt.ShowDialog();
        }

    }
   
}

