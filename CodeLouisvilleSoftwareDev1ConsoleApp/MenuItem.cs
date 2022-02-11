using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    abstract class MenuItem
    {
        public string Choice { get; set; }
        public abstract bool ExecuteChoice();
    }
}
