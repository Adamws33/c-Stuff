using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0._13GettersSetters
{
    class Employee
    {
        //Fields
        //generally use an _ to start with
        private int _id;


        //Constructors - Context


        //Properties
        public int EmployeeId
        {
            set
            {
                if (EmployeeId < 1)
                    throw new Exception("The Employee ID is not valid.");
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }

        private string _name;

        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("The value is empty please enter valid name");
                _name = value;
            }

            get
            {
                return _name;
            }
            
        }


        //Methods - Context


    }
}
