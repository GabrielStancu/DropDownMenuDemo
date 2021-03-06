﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaterialDesignThemes.Wpf;
using System.Windows.Controls;

namespace DropDownMenu.ViewModel
{
    public class ItemMenu
    {
        public string Header { get; private set; }
        public List<SubItem> SubItems { get; private set; }
        public PackIconKind Icon { get; private set; }
        public UserControl Screen { get; private set; }

        public ItemMenu(string header, List<SubItem> subItems, PackIconKind icon)
        {
            Header = header;
            SubItems = subItems;
            Icon = icon;
        }

        public ItemMenu(string header, UserControl screen, PackIconKind icon)
        {
            Header = header;
            Screen = screen;
            Icon = icon;
        }
    }
}
