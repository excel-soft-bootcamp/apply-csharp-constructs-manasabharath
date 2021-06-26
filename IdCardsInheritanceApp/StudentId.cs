using System;
using System.Collections.Generic;
using System.Text;

namespace IdCardsInheritanceApp
{
    class StudentId:UserDetails
    { 
        string _course;
      
        public StudentId(string course, int idno, int age, string name, string college) : base(idno, age, name, college)
        {
            this._course = course;

        }
    }
}
