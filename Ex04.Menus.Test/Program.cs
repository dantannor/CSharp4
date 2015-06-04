using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main(string[] args)
        {
            runInterfaceTest();
        }

        private static void runInterfaceTest()
        {
            IAction action = ;
            Interfaces.MainMenu menu = new MainMenu();
            menu.AddSubItem("Show Date/Time");
            menu.AddSubItem("Info");

            menu.GetSubMenuItem("Show Date/Time").AddActionItem("Show Time",);
        }
    }
}
