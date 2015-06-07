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
        private readonly string m_MenuItemName;

        public MenuItem(string i_SubItemName)
        {
            m_MenuItemName = i_SubItemName;
            _ShowEvent += this.Show;
        }

        public void Run()
        {
            OnShower();
        }

        public override string ToString()
        {
            return string.Format("{0}", this.m_MenuItemName);
        }
    }
}
