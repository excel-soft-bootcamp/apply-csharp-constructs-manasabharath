using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChildApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem _securitySystem = new SecuritySystem();
            DoorStatusState _doorStatusState= new DoorStatusState(_doorStatusState.Notify);
            _securitySystem.Notify.SMS();




            Door Door1 = new Door();
            Door1.DoorStatusStateChanged += _doorStatusState;
            Door1.Open();
            Door1.Close();





        }
    }
}
