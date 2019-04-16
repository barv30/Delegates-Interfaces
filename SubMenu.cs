using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Delegates
{
    public class SubMenu : MenuItem
    {
        private const int k_ExitOrBackNumber = 0;
        private readonly List<MenuItem> m_MenuItems = new List<MenuItem>();
        private string m_ExitOrBackString;
        
        public SubMenu(string i_ExitOrBackString, string m_TitleOfThisSubMenu) : base(m_TitleOfThisSubMenu)
        {
            m_ExitOrBackString = i_ExitOrBackString;
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            m_MenuItems.Add(i_MenuItem);
        }

        private void showSubMenu()
        {
            int countOfOptionsToSelect = 0;
            Console.WriteLine("{0}. {1}", countOfOptionsToSelect++, m_ExitOrBackString);

            foreach (MenuItem currentSubMenu in m_MenuItems)
            {
                Console.WriteLine("{0}. {1}", countOfOptionsToSelect++, currentSubMenu.TitleOfItem);
            }
        }

        public override void RunTheItem()
        {
            bool isTheRunOver = false;
            int usersInput;
            while (!isTheRunOver)
            {
                Console.Clear();
                Console.WriteLine(m_TitleOfItem + ":");
                showSubMenu();
                usersInput = getUsersInput(0, m_MenuItems.Count);
                if (usersInput == k_ExitOrBackNumber)
                {
                    isTheRunOver = true;
                }
                else
                {
                    m_MenuItems[usersInput - 1].RunTheItem();
                }
            }
        }

        private int getUsersInput(int i_MinOption, int i_MaxOption)
        {
            int o_UserChoiceNumber;

            Console.WriteLine("Please insert your choice:");
            string userChoice = Console.ReadLine();

            bool isNumber = int.TryParse(userChoice, out o_UserChoiceNumber);

            if (!isNumber || o_UserChoiceNumber < i_MinOption || o_UserChoiceNumber > i_MaxOption)
            {
                Console.WriteLine("Your input is invalied! enter again number between {0} - {1}!", i_MinOption, i_MinOption);
                o_UserChoiceNumber = getUsersInput(i_MinOption, i_MaxOption);
            }

            return o_UserChoiceNumber;
        }        
    }
}
