using System;
using System.Collections.Generic;
using System.Text;

namespace IdCardsInheritanceApp
{
    class TeacherIdCard:UserDetails
    {
        private string _dept;

        public TeacherIdCard(string dept, int idno, int age, string name, string college) : base(idno, age, name, college)
        {
            this._dept = dept;
        }
    }
}
