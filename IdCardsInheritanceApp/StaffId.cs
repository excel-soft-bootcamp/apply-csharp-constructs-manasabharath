using System;
using System.Collections.Generic;
using System.Text;

namespace IdCardsInheritanceApp
{
    class StaffIdCard:UserDetails
    {
        private string _designation;
        public StaffIdCard(string designation, int idno, int age, string name, string college) : base(idno, age, name, college)
        {

            this._designation = designation;

        }
    }
}
