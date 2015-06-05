using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ShowVersion : IAction
    {
        public void RunAction()
        {
            Console.WriteLine("Version: 15.2.4.0");
            Console.ReadLine();
        }
    }
}
