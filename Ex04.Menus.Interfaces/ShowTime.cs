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
            string time = DateTime.Now.ToString("HH:mm:ss tt");
            Console.WriteLine(time);
            Console.ReadLine();
        }
    }
}
