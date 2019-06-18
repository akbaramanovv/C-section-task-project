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

namespace C_sharp_project
{
    public partial class GroupVithtasks : Form
    {
        Modelss.Task task = new Modelss.Task();
        Modelss.StudentsMark smm = new Modelss.StudentsMark();
        TaskForm tf = new TaskForm();
        private readonly int _taskID, _groupID;
        public GroupVithtasks(int taskID, int groupID)
        {
            _taskID = taskID;
            _groupID = groupID;
            InitializeComponent();
        }

        private void GroupVithtasks_Load(object sender, EventArgs e)
        {
            GenerateTasks();
            btnmark2.Enabled = false;
        }

        private void GenerateTasks()
        {
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                dvgsmark2.Rows.Clear();
                List<Modelss.Student> students = db.Students.Where(s => s.GroupId == _groupID).ToList();
                foreach (var item in students)
                {
                    List<Modelss.StudentsMark> studentsMark = db.StudentsMarks.Where(sm => sm.StudentId == item.Id && sm.TaskId == _taskID).ToList();
                    Modelss.Task task = item.Group.Tasks.FirstOrDefault(t => t.Id == _taskID);
                    string taskName = "";
                    int taskMark = 0;
                    if (task != null)
                    {
                        taskName = task.Name;
                        Modelss.StudentsMark smark = task.StudentsMarks.FirstOrDefault(sm => sm.StudentId == item.Id);
                        if (smark != null)
                        {
                            taskMark = smark.Mark;
                        }

                    }
                    dvgsmark2.Rows.Add( item.Id, task.Id, item.Name, item.Surname, taskName, taskMark);

                }
            }
        }

        private void Dvgsmark2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnmark2.Enabled = true;
            txtmark.Text = dvgsmark2.CurrentRow.Cells[5].Value.ToString();
            //MessageBox.Show(dvgsmark2.CurrentRow.Cells[1].Value.ToString());
        }

        private void Btnmark2_Click(object sender, EventArgs e)
        {
            int affectedRows = 0;
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                smm.Id =(int)dvgsmark2.CurrentRow.Cells[0].Value;
                Modelss.StudentsMark SM = db.StudentsMarks.Where(s => s.StudentId == smm.Id).FirstOrDefault();

                //validation only numbers
                String patternnum = "^[0-9]+(,[0-9]+)*$";
                Regex mark = new Regex(patternnum);
                Match numMatch = mark.Match(txtmark.Text);
                if (!numMatch.Success)
                {
                    MessageBox.Show("Yalniz ededler daxil edin");
                    txtmark.Text = "";
                    return;
                }
                SM.Mark = Convert.ToInt32(txtmark.Text);
                SM.StudentId = (int)dvgsmark2.CurrentRow.Cells[0].Value;
                SM.TaskId = (int)dvgsmark2.CurrentRow.Cells[1].Value;
                affectedRows = db.SaveChanges();
                //dvgsmark2.CurrentRow.Cells[5].Value = txtmark.Text;
                btnmark2.Enabled = false;
                txtmark.Text = "";
                GenerateTasks();
            }
            if (affectedRows > 0)
            {
                MessageBox.Show("success");
                return;
            }
            else
            {
                MessageBox.Show("error");
                return;
            }
           
        }

        private void GroupVithtasks_Activated(object sender, EventArgs e)
        {
           
        }
    }
}
