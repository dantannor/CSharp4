// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShowVersion.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex04.Menus.Delegates
{
    using System;

    public class ShowVersion : IAction
    {
        public void RunAction()
        {
            Console.WriteLine("Version: 15.2.4.0");
            Console.ReadLine();
        }
    }
}
