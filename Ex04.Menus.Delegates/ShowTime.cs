using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ShowTime : IAction
    {
        public void RunAction()
        {
            string s = DateTime.Now.ToString("HH:mm:ss tt");
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}
