using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
                    return (menuItem as SubMenuItem);
                }
            }
            throw new Exception("Not found");

        }

        public void Show()
        {
            displayCurrentMenuLevel();
            System.Console.WriteLine("Please choose an option:");
            string userInput = System.Console.ReadLine();
            int userChoice;
            while (!int.TryParse(userInput, out userChoice))
            {
                System.Console.WriteLine("Invalid input, try again:");
                userInput = System.Console.ReadLine();
            }
            Console.Clear();
            m_AllMenuItemsInCurrentLevel[userChoice].Run();
        }

        private void displayCurrentMenuLevel()
        {
            int itemNumber = 1;
            foreach (IMenuItem menuItem in m_AllMenuItemsInCurrentLevel)
            {
                System.Console.WriteLine(string.Format("{0}. {1}", itemNumber, m_AllMenuItemsInCurrentLevel[itemNumber++-1].ToString()));
            }
        }
    }
}
