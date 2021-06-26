using System;
using System.Collections.Generic;
using System.Text;

namespace IdCardsInheritanceApp
{
    class GuestId
    {
        private int _validtill;
        public GuestId(int validtill, int idno, int age, string name, string college) : base(idno, age, name, college)
        {

            this._validtill = validtill;

        }
    }
}
