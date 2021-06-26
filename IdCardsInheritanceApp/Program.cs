using System;

namespace IdCardsInheritanceApp
{
    class Program
    {
    
            static void Main()
            {
                StudentId _studentid = new StudentId("BE",1001, 30, "abc", "abccollege");
                TeacherId _teacherId = new TeacherId("cse",200,31,"xyx","abccollege");
                StaffId _staffid = new StaffId("clerk", 1005, 40, "ram", "abccollege");
                GuestId _guestId = new GuestId(20 - 06 - 2021, 1006, 36, "prabhu", "abccollege");


            }
        
    }

 
}
