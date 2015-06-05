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
            IAction ShowTimeAction = new ShowTime();
            IAction ShowDate = new ShowDate();
            IAction ShowVersion = new ShowVersion();
            IAction CountWords = new CountWords();
            Interfaces.MainMenu menu = new MainMenu();
            menu.AddSubItem("Show Date/Time");
            menu.AddSubItem("Info");

            menu.GetSubMenuItem("Show Date/Time").AddActionItem("Show Time", ShowTimeAction);
            menu.GetSubMenuItem("Show Date/Time").AddActionItem("Show Date", ShowDate);

            menu.GetSubMenuItem("Info").AddActionItem("Show Version",ShowVersion );
            menu.GetSubMenuItem("Info").AddActionItem("Count Words", CountWords);
            menu.Show();
        }
         
    }
}
