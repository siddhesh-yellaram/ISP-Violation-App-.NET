using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    public interface IWorkable
    {
        void StartWork();
        void StopWork();
        void StartEat();
        void StopEat();
    }
}
