﻿using System;
using System.Collections.Generic;
using System.Text;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ActionCountCapitals : IDoAction
    {
        public void RunActionSelect()
        {
            ActionMethods active = new ActionMethods();
            active.countCapitalLetters();
        }      
    }
}
