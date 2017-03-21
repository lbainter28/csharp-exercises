using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }

    public class MenuItem
    {
        private decimal price;
        private string description;
        private string category;
        private bool isNew;

        private static readonly string[] categories = new string[] { "appetizer", "main dish", "dessert" };

        public decimal Price
        {
            get { return price; }
            private set { price = value; }
        }

        public string Description
        {
            get { return description; }
            private set { description = value; }
        }

        public string Category
        {
            get { return category; }
            private set
            {
                if (!categories.Contains(value))
                {
                    return;
                }
                category = value;
            }
        }

        public bool IsNew
        {
            get { return isNew; }
            private set { isNew = value; }
        }

        public MenuItem(string description, decimal price, string category, bool isNew)
        {
            Description = description;
            Price = price;
            Category = category;
            IsNew = isNew;
        }
    }


    public class Menu
    {
        private readonly List<MenuItem> menuItems;
        private DateTime lastUpdated;

        public Menu()
        {
            menuItems = new List<MenuItem>();
            LastUpdated = DateTime.Now;
        }

        public DateTime LastUpdated
        {
            get { return lastUpdated; }
            private set { lastUpdated = value; }
        }

        public MenuItem[] MenuItems
        {
            get
            {
                return menuItems.ToArray();
            }
        }

        public void AddItem(MenuItem item)
        {
            menuItems.Add(item);
            lastUpdated = DateTime.Now;
        }





    }
}
