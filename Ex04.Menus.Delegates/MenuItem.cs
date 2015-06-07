// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuItem.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------

namespace Ex04.Menus.Delegates
{
    public delegate void DelegateMenu(string iMenuItemName);

    public class MenuItem : MainMenu, IMenuItem
    {
        public event DelegateMenu m_OpenMenuNotifier;

        private readonly string m_MenuItemName;

        public MenuItem(string iMenuItemName)
        {
            this.m_MenuItemName = iMenuItemName;
        }

        /// <summary>
        /// Shows the menu item
        /// </summary>
        public void Run()
        {
          this.Show();
        }

        public void OnOpenMenu()
        {
            m_OpenMenuNotifier.Invoke(m_MenuItemName);
        }

        public override string ToString()
        {
            return string.Format("{0}", this.m_MenuItemName);
        }
    }
}
