using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolSecondday.IheritanceIO
{
    class Mobile
    {
        public void incomingCall()
        {
            Console.WriteLine("Incoming call");
        }
        public void outgoingCall() 
        {
            Console.WriteLine("OutGoingCall");
        }

    }
    class SmartPhone : Mobile
    {
        public void Camera()
        {
            Console.WriteLine("Camera Feature");
        }

    }
    class Android:SmartPhone
    {
        public void anderiodVersion()
        {
            Console.WriteLine("Android Version");
        }
        public void WiFi()
        {
            Console.WriteLine("Wifi Features");
        }
        static void Main(string[] args)
        {
            Android an = new Android();
            an.incomingCall();
            an.Camera();
            an.outgoingCall();
            an.WiFi();
            an.anderiodVersion();
            Console.ReadKey();
        }
        

    }

}
