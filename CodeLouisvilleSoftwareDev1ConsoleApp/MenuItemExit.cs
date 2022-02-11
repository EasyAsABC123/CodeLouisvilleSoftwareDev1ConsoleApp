using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeLouisvilleSoftwareDev1ConsoleApp
{
    internal class MenuItemExit : MenuItem
    {
        public MenuItemExit()
        {
            this.Choice = "Exit";
        }

        public override bool ExecuteChoice()
        {
            return false;
        }
    }
}
