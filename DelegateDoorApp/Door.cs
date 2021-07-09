using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateChildApp
{

    public delegate void DoorStatusState(string status);
    //Observable
    public  class Door
    {
        string DoorStatus;
       public event DoorStatusState DoorStatusStateChanged;
        public void Open()
        {
            DoorStatus = "open";
            DoorStatusStateChanged.Invoke(this.DoorStatus);



}
        public void Close()
        {
             DoorStatus = "close";

            DoorStatusStateChanged.Invoke(this.DoorStatus);
        }

        
    }
    
}
    

