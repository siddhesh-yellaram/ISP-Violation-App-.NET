using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    class Robots : IWorkable
    {
        public void StartEat()
        {
            throw new Exception("Robots cannot eat!!!");
        }

        public void StartWork()
        {
            Console.WriteLine("Robots have started working");
        }

        public void StopEat()
        {
            throw new Exception("Robots cannot eat!!!");
        }

        public void StopWork()
        {
            Console.WriteLine("Robots have stopped working");
        }
    }
}
