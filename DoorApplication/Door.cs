using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApplication
{
    public delegate void DoorStatusHandler(string status);
    public class Door
    {
        string doorStatus = "";
        public event DoorStatusHandler OnDoorActionChanged;
        public void Open()
        {
            doorStatus = "Open";
            OnDoorActionChanged.Invoke(doorStatus);

            this.SendNotification();
        }
        public void Close()
        {
            doorStatus = "Close";
            OnDoorActionChanged.Invoke(doorStatus);
            this.SendNotification();
        }
        public void SendNotification()
        {
            string notify = $"{this.doorStatus} and Time : {System.DateTime.Now.ToString()}";
            OnDoorActionChanged.Invoke(notify);
        }
    }
}
