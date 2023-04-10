using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDrawerApp
{
    public class MenuItem
    {
        public string Name { get; private set; }
        public PackIconKind Icon { get; private set; }
        public ItemCount Count { get; private set; }


        public MenuItem(String name, PackIconKind icon, ItemCount count)
        {
            Name = name;
            Icon = icon;
            Count = count;
        }

    }
}
