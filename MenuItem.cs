using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public abstract class MenuItem
    {
        protected string m_TitleOfItem;

        public MenuItem(string i_TitleOfItem)
        {
            m_TitleOfItem = i_TitleOfItem;
        }

        public string TitleOfItem
        {
            get { return m_TitleOfItem; }
        }

        public abstract void RunTheItem();
    }
}
