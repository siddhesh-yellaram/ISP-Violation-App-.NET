using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ISPViolationApp.Model;

namespace ISPViolationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                DoAllJobs(new Managers());
                DoAllJobs(new Robots());
            }
            catch(Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            Console.ReadLine();
        }

        static void DoAllJobs(IWorkable i)
        {
            i.StartEat();
            i.StopEat();
            i.StartWork();
            i.StopWork();
        }
    }
}
