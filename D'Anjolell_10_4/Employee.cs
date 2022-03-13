using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Anjolell_10_4
{
    class Employee
    {
        //Declare Variables
        private string _name, _department, _position;
        private int _idNumber;

        public Employee(string susName, string susDepartment, string susPosition, int susIdNumber) 
        {
            //Constructor that sets variables to values of the employee named susan
            _name = "Susan Meyers";
            _department = "Accounting";
            _position = "Vice President";
            _idNumber = 47899;
            return;
        }

        public Employee(string markName, int markIdNumber)
        {
            //Constructor that sets some variables to values of the employee named mark and some to default values
            _name = "Mark Jones";
            _department = "";
            _position = "";
            _idNumber = 39119;
            return;
        }

        public Employee()
        {
            //Constructor that sets all variables to default values
            _name = "";
            _department = "";
            _position = "";
            _idNumber = 0;
        }

        public string Name
        {
            //Getter and setter for name variable
            get 
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }

        public string Department
        {
            //Getter and setter for department variable
            get
            {
                return _department;
            }
            set
            {
                _department = value;
            }
        }

        public string Position
        {
            //Getter and setter for position variable
            get
            {
                return _position;
            }
            set
            {
                _position = value;
            }
        }

        public int idNumber
        {
            //Getter and setter for idNumber variable
            get
            {
                return _idNumber;
            }
            set
            {
                _idNumber = value;
            }
        }
    }
}
