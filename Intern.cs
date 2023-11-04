/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Illustration.Intern
{
    public class Intern
    {
        private string _name;
        private string _gender;
        private DateTime _createdAt;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Gender
        {
            get { return _gender; }
            set
            {
                if (value == "Male" || value == "Female")
                {
                    this._gender = value;
                }
                else
                {
                    throw new Exception("Invalid Gender");
                }
            }
        }
        

        public  DateTime CreatedAt
        { 
            get { return _createdAt; }
        }
        public Intern()
        {
            this._createdAt = DateTime.Now;
        }
}
    }


*/