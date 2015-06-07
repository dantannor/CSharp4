// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShowTime.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex04.Menus.Interfaces
{
    using System;

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
