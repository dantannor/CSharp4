using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MainMenu
    {
        private int m_Level = 1;
        private readonly List<IMenuItem> m_CurMenuItems;

        /*
         * Constructor
         */
        public MainMenu()
        {
            this.m_CurMenuItems = new List<IMenuItem>();
        }

        /// <summary>
        /// Add an action item 
        /// </summary>
        /// <param name="i_ActionItemName">Action Name</param>
        /// <param name="i_Action">Action</param>
        public void AddActionItem(string i_ActionItemName, IAction i_Action)
        {
            ActionItem actionItem = new ActionItem(i_ActionItemName, i_Action);
            this.m_CurMenuItems.Add(actionItem);
        }

        /// <summary>
        /// Add sub item
        /// </summary>
        /// <param name="i_SubItemName">Name of subitem</param>
        public void AddSubItem(string i_SubItemName)
        {
            MenuItem item = new MenuItem(i_SubItemName);
            this.m_CurMenuItems.Add(item);
        }

        public MainMenu GetSubMenuItem(string i_SubMenuItemName)
        {
            foreach (IMenuItem menuItem in this.m_CurMenuItems)
            {
                if (menuItem.ToString().Equals(i_SubMenuItemName))
                {
                    MainMenu newMenu= menuItem as MenuItem;
                    if (newMenu == null) continue;
                    newMenu.m_Level++;
                    return (newMenu);
                }
            }
            throw new Exception("Not found");

        }

        /// <summary>
        /// Shows the items
        /// </summary>
        public void Show()
        {
            while (true)
            {
                Console.Clear();
                displayCurrentMenuLevel();
                System.Console.WriteLine("Please choose an option:");
                string userInput = Console.ReadKey().KeyChar.ToString();
                int userChoice;

                while (!int.TryParse(userInput, out userChoice) || userChoice > m_CurMenuItems.Count)
                {
                    Console.WriteLine();
                    System.Console.WriteLine("Invalid input, try again");
                    Thread.Sleep(1000);
                    Console.Clear();

                    displayCurrentMenuLevel();
                    System.Console.WriteLine("Please choose an option:");
                    userInput = Console.ReadKey().KeyChar.ToString();
                }

                // Exit
                if (this.m_Level == 1 && userChoice == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Bye");
                    Thread.Sleep(1500);
                    System.Environment.Exit(0);
                }
                else if (userChoice == 0)
                {
                    // Back to the previous menu
                    break;
                }

                Console.Clear();
                if (this.m_CurMenuItems[userChoice - 1] is ActionItem)
                {
                    Console.WriteLine("Running {0}", this.m_CurMenuItems[userChoice - 1].ToString());
                }

                this.m_CurMenuItems[userChoice - 1].Run();  
            }
        }

        /// <summary>
        /// Display the items of the current menu level
        /// </summary>
        private void displayCurrentMenuLevel()
        {
            int itemNumber = 1;
            foreach (IMenuItem menuItem in this.m_CurMenuItems)
            {
                System.Console.WriteLine(
                    string.Format("{0}. {1}", itemNumber, this.m_CurMenuItems[itemNumber++ - 1].ToString()));
            }

            // Exit or back button
            Console.WriteLine();
            Console.WriteLine(this.m_Level == 1 ? "0. Exit" : "0. Back");
            Console.WriteLine();
        }
    }
}
