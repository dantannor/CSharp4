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
        private int m_level = 1;
        private List<IMenuItem> m_AllMenuItemsInCurrentLevel;

        public MainMenu()
        {
            m_AllMenuItemsInCurrentLevel = new List<IMenuItem>();
        }

        public void AddActionItem(String i_ActionItemName, IAction i_Action)
        {
            ActionItem actionItem = new ActionItem(i_ActionItemName, i_Action);
            m_AllMenuItemsInCurrentLevel.Add(actionItem);
        }

        public void AddSubItem(string i_SubItemName)
        {
            SubMenuItem subItem = new SubMenuItem(i_SubItemName);
            m_AllMenuItemsInCurrentLevel.Add(subItem);
        }

        public MainMenu GetSubMenuItem(string i_SubMenuItemName)
        {
            foreach (IMenuItem menuItem in m_AllMenuItemsInCurrentLevel)
            {
                if (menuItem.ToString().Equals(i_SubMenuItemName))
                {
                    MainMenu newMenu= menuItem as SubMenuItem;
                    if (newMenu == null) continue;
                    newMenu.m_level++;
                    return (newMenu);
                }
            }
            throw new Exception("Not found");

        }

        public void Show()
        {
            while (true)
            {
                Console.Clear();
                displayCurrentMenuLevel();
                System.Console.WriteLine("Please choose an option:");
                string userInput = System.Console.ReadLine();
                int userChoice;
                while (!int.TryParse(userInput, out userChoice))
                {
                    System.Console.WriteLine("Invalid input, try again:");
                    userInput = System.Console.ReadLine();
                }
                // Exit
                if (m_level == 1 && userChoice == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Bye");
                    Thread.Sleep(1500);
                    System.Environment.Exit(0);
                }
                // Back to the previous menu
                else if (userChoice == 0)
                {
                    break;
                }
                Console.Clear();
                if (m_AllMenuItemsInCurrentLevel[userChoice - 1] is ActionItem)
                {
                    Console.WriteLine("Running {0}", m_AllMenuItemsInCurrentLevel[userChoice-1].ToString());
                }
                m_AllMenuItemsInCurrentLevel[userChoice - 1].Run();  
            }

        }

        private void displayCurrentMenuLevel()
        {
            int itemNumber = 1;
            foreach (IMenuItem menuItem in m_AllMenuItemsInCurrentLevel)
            {
                System.Console.WriteLine(string.Format("{0}. {1}", itemNumber, m_AllMenuItemsInCurrentLevel[itemNumber++-1].ToString()));
                
            }
            if (m_level == 1)
            {
                Console.WriteLine("0. Exit");
            }
            else
            {
                Console.WriteLine("0. back");
            }
        }
    }
}
