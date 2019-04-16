using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class MenuByInterfaces
    {
        private const string k_BackString = "Back";
        private readonly MainMenu r_MainMenu = new MainMenu();
        
        public MenuByInterfaces()
        {
            IDoAction actionShowTime = new ActionShowTime();
            IDoAction actionShowDate = new ActionShowDate();
            IDoAction actionCountCapitals = new ActionCountCapitals();
            IDoAction actionShowVersion = new ActionShowVersion();
      
            ActionInMenu action1 = new ActionInMenu("Show Time", actionShowTime);
            ActionInMenu action2 = new ActionInMenu("Show Date", actionShowDate);
            ActionInMenu action3 = new ActionInMenu("Count Capitals", actionCountCapitals);
            ActionInMenu action4 = new ActionInMenu("Show Version", actionShowVersion);
            
            SubMenu subMenu1 = new SubMenu(k_BackString, "Show Date/Time");
            SubMenu subMenu2 = new SubMenu(k_BackString, "Version and Capitals" );
           
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
