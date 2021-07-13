using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            SecuritySystem _securitySystem = new SecuritySystem();
            DoorStatusHandler handler = new DoorStatusHandler(_securitySystem.Sms);
            Door door = new Door();
            door.OnDoorActionChanged += handler;
            door.Open();
            door.Close();

        }
    }
}
