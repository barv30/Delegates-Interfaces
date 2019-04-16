using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public delegate void DoTheActionDelegate();

    public class ActionInMenu : MenuItem
    {
        public event DoTheActionDelegate ActionToDo;

        public ActionInMenu(string i_TitleOfAction) : base(i_TitleOfAction)
        {
        }

        public override void RunTheItem()
        {
            Console.Clear();
            if (ActionToDo != null)
            {
                ActionToDo.Invoke();
            }
        }
    }
}
