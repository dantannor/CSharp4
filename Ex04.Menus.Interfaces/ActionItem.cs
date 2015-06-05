using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class ActionItem : IMenuItem
    {
        private readonly IAction m_Action;
        private string m_ActionItemName;

        public ActionItem(string i_ActionItemName, IAction i_Action)
        {
            m_ActionItemName = i_ActionItemName;
            m_Action = i_Action;
        }

        public void Run()
        {
            m_Action.RunAction();
        }

        public override string ToString()
        {
            return string.Format("{0}", m_ActionItemName);
        }

    }

    public interface IAction
    {
        void RunAction();
    }

}
