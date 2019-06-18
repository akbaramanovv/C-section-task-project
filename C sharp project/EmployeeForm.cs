using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using C_sharp_project.Modelss;

namespace C_sharp_project
{
    public partial class EmployeeForm : Form
    {
      
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Activated(object sender, EventArgs e)
        {
            dvgemp.Rows.Clear();

            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                List<Position> p = db.Positions.ToList();
                foreach (var item in p)
                {
                    eposition.Items.Add(item.Name);
                }
               
                List<Modelss.Employee> employees = db.Employees.ToList();
                foreach (var item in employees)
                {
                    dvgemp.Rows.Add(item.Id , item.Name, item.Surname, item.Email, item.Phone, item.Position.Name , item.Start_Time, item.Salary);
                }
            }
        }

        private void EmpSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show(timee.Value.ToString());
            using (Modelss.AKADEMIYAEntities2 db = new Modelss.AKADEMIYAEntities2())
            {
                //Modelss.Employee emp = new Modelss.Employee();
                //int selected = eposition.SelectedIndex;
                //List<Modelss.Position> position = db.Positions.ToList();
                //int posID = position[selected].Id;
                //emp.PositionId = posID;
                //emp.Name = Ename.Text;
                //emp.Surname = esurname.Text;
                //emp.Phone = ephone.Text;
                //emp.Salary = Convert.ToDouble(esalaryy.Text);
                //emp.Start_Time = Convert.ToDateTime(timee.Value);

                //db.Employees.Add(emp);
                //db.SaveChanges();
            }
          
        }
    }
}
