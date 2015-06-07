using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ShowDate : IAction
    {
        public void RunAction()
        {
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            Console.WriteLine(date);
            Console.ReadLine();
        }
    }
}
