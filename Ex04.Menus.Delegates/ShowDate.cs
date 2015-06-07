// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ShowDate.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex04.Menus.Delegates
{
    using System;

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
