using System;
using System.Collections.Generic;
using System.Text;

namespace IdCardsInheritanceApp
{
    class TeacherId:UserDetails
    {
        private string _dept;

        public TeacherId(string dept, int idno, int age, string name, string college) : base(idno, age, name, college)
        {
            this._dept = dept;
        }
    }
}
