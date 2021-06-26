using System;
using System.Collections.Generic;
using System.Text;

namespace IdCardsInheritanceApp
{
  
        public abstract class UserDetails
        {
            private int _idno, _age;
            private string _name, _college;


            public UserDetails(int idno)
            {
                this._idno = idno;
            }

            public UserDetails(int idno, int age) : this(idno)
            {

                this._age = age;

            }

            public UserDetails(int idno, int age, string name) : this(idno, age)
            {

                this._name = name;

            }
            public UserDetails(int idno, int age, string name, string college) : this(idno, age, name)
            {

                this._college = college;

            }



        }


}
