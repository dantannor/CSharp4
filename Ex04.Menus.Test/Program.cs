﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex04.Menus.Test
{
    using Ex04.Menus.Interfaces;

    public class Program
    {
        public static void Main(string[] args)
        {
        
            interfaceTest();
            delegateTest();

        }
        
        private static void interfaceTest()
        {
            IAction ShowTimeAction = new ShowTime();
            IAction ShowDate = new ShowDate();
            IAction ShowVersion = new ShowVersion();
            IAction CountWords = new CountWords();
            MainMenu menu = new MainMenu();
            menu.AddMenuItem("Show Date/Time");
            menu.AddMenuItem("Info");

            menu.GetMenuItem("Show Date/Time").AddActionItem("Show Time", ShowTimeAction);
            menu.GetMenuItem("Show Date/Time").AddActionItem("Show Date", ShowDate);

            menu.GetMenuItem("Info").AddActionItem("Show Version", ShowVersion );
            menu.GetMenuItem("Info").AddActionItem("Count Words", CountWords);
            menu.Show();
        }

        private static void delegateTest()
        {
            IAction ShowTimeAction = new ShowTime();
            IAction ShowDate = new ShowDate();
            IAction ShowVersion = new ShowVersion();
            IAction CountWords = new CountWords();
            MainMenu menu = new MainMenu();
            menu.AddMenuItem("Show Date/Time");
            menu.AddMenuItem("Info");

            menu.GetMenuItem("Show Date/Time").AddActionItem("Show Time", ShowTimeAction);
            menu.GetMenuItem("Show Date/Time").AddActionItem("Show Date", ShowDate);

            menu.GetMenuItem("Info").AddActionItem("Show Version", ShowVersion);
            menu.GetMenuItem("Info").AddActionItem("Count Words", CountWords);
            menu.Show();
        }
         
    }
}
