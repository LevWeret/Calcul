﻿using Domain;
using System;

namespace Infrastructure
{
    public sealed class OperationMenuItemSelectorView : IMenuItemSelectorProvider
    {
        public int GetMenuItemId()
        {
            Console.Write("Выберите действие: ");
            return Convert.ToInt32(Console.ReadLine());
        }
    }
}
