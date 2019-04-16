using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class MenuByDelegates
    {
        private const string k_BackString = "Back";
        private readonly MainMenu r_MainMenu = new MainMenu();
        
        public MenuByDelegates()
        {
            ActionMethods methods = new ActionMethods();

            DoTheActionDelegate actionShowTime = new DoTheActionDelegate(methods.showTime);
            DoTheActionDelegate actionShowDate = new DoTheActionDelegate(methods.showDate);
            DoTheActionDelegate actionCountCapitals = new DoTheActionDelegate(methods.countCapitalLetters);
            DoTheActionDelegate actionShowVersion = new DoTheActionDelegate(methods.showVersion);

            ActionInMenu action1 = new ActionInMenu("Show Time");
            ActionInMenu action2 = new ActionInMenu("Show Date");
            ActionInMenu action3 = new ActionInMenu("Count Capitals");
            ActionInMenu action4 = new ActionInMenu("Show Version");

            action1.ActionToDo += actionShowTime;
            action2.ActionToDo += actionShowDate;
            action3.ActionToDo += actionCountCapitals;
            action4.ActionToDo += actionShowVersion;

            SubMenu subMenu1 = new SubMenu(k_BackString, "Show Date/Time");
            SubMenu subMenu2 = new SubMenu(k_BackString, "Version and Capitals");

            subMenu1.AddMenuItem(action1);
            subMenu1.AddMenuItem(action2);

            subMenu2.AddMenuItem(action3);
            subMenu2.AddMenuItem(action4);

            r_MainMenu.AddNewItemToMainMenu(subMenu1);
            r_MainMenu.AddNewItemToMainMenu(subMenu2);

            r_MainMenu.Show();
        }
    }
}
