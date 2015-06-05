using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    class SubMenuItem : MainMenu, IMenuItem
    {
        private string m_SubItemName;

        public SubMenuItem(string i_SubItemName)
        {
            m_SubItemName = i_SubItemName;
        }

        public void Run()
        {
          this.Show();
        }

        public override string ToString()
        {
            return string.Format("{0}", m_SubItemName);
        }
    }
}
