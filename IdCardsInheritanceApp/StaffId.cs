using System;
using System.Collections.Generic;
using System.Text;

namespace IdCardsInheritanceApp
{
    class StaffId:UserDetails
    {
        private string _designation;
        public StaffId(string designation, int idno, int age, string name, string college) : base(idno, age, name, college)
        {

            this._designation = designation;

        }
    }
}
