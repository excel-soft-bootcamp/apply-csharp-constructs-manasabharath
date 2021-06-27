using System;

namespace IdCardsInheritanceApp
{
    class Program
    {
    
            static void Main()
            {
                StudentIdCard _studentidcard = new StudentIdCard("BE",1001, 30, "abc", "abccollege");
                TeacherIdCard _teacherIdcard = new TeacherIdCard("cse",200,31,"xyx","abccollege");
                StaffIdCard _staffidcard = new StaffIdCard("clerk", 1005, 40, "ram", "abccollege");
                GuestIdCard _guestIdcard = new GuestIdCard(20 - 06 - 2021, 1006, 36, "prabhu", "abccollege");


            }
        
    }

 
}
