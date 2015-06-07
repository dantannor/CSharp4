// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ActionItem.cs" company="">
//   
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Ex04.Menus.Delegates
{
    using System;

    public class ActionItem : IMenuItem
    {
        private readonly Action m_Action;
        private readonly string m_ActionItemName;

        public ActionItem(string i_ActionItemName, Action i_Action)
        {
            m_ActionItemName = i_ActionItemName;
            m_Action = i_Action;
        }

        public void Run()
        {
            m_Action.Invoke();
        }

        public override string ToString()
        {
            return string.Format("{0}", m_ActionItemName);
        }
    }
}
