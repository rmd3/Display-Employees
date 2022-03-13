using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D_Anjolell_10_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            //Richard D'Anjolell
            //Declare Variables
            string susName = "";
            int susID = 0;
            string susDept = "";
            string susPos = "";
            string markName = "";
            int markID = 0;
            string[] joyInfo = { "Joy Rogers", "Manufacturing", "Engineer", "81774"};
            Employee susanMeyers = new Employee(susName, susDept, susPos, susID);
            Employee markJones = new Employee(markName, markID);
            Employee joyRogers = new Employee();

            //Fill in missing data for Mark
            markJones.Department = "IT";
            markJones.Position = "Programmer";

            //Fill in data for Joy
            joyRogers.Name = joyInfo[0];
            joyRogers.Department = joyInfo[1];
            joyRogers.Position = joyInfo[2];
            joyRogers.idNumber = int.Parse(joyInfo[3]);

            //Output data to form
            txtSusName.Text = susanMeyers.Name;
            txtSusID.Text = susanMeyers.idNumber.ToString();
            txtSusDept.Text = susanMeyers.Department;
            txtSusPos.Text = susanMeyers.Position;
            txtMarkName.Text = markJones.Name;
            txtMarkID.Text = markJones.idNumber.ToString();
            txtMarkDept.Text = markJones.Department;
            txtMarkPos.Text = markJones.Position;
            txtJoyName.Text = joyRogers.Name;
            txtJoyID.Text = joyRogers.idNumber.ToString();
            txtJoyDept.Text = joyRogers.Department;
            txtJoyPos.Text = joyRogers.Position;
        }
    }
}
