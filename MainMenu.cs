using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class MainMenu
    {
        public const string k_ExitString = "Exit";
        private readonly SubMenu r_FirstMenu = new SubMenu(k_ExitString, "Main Menu by delegates");

        public void Show()
        {
            r_FirstMenu.RunTheItem();
        }

        public void AddNewItemToMainMenu(MenuItem i_MenuItem)
        {
            r_FirstMenu.AddMenuItem(i_MenuItem);
        }
    }
}
