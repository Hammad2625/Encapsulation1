using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace GeterSeter
{
    internal class Name
    {
        private string _firstname;
        private string _lastname;
        private int _age;

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }

        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }
        public int Age
        { get { return _age; }
          set {_age = value; } 
        }

        public string Naam()
        {
            return _firstname+" "+ _lastname+" "+ _age;
        }
    }

}
