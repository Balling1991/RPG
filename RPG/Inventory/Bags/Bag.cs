using RPG.Items;
using System;
using System.Collections.Generic;

namespace RPG.Inventory.Bags
{
    public abstract class Bag : IItem
    {
        private readonly List<Item> _items = new List<Item>();

        public abstract int ExtendedCapacity { get; }

        public int GetAmountOfItems()
        {
            return _items.Count;
        }

        public void AddItem(Item item)
        {
            if(Inventory.Instance.GetFullCapacity() == _items.Count)
                Console.WriteLine("Your inventory is full.");
            else
                _items.Add(item);
        }

        public void RemoveItem(Item item)
        {
            if (_items.Contains(item))
                _items.Remove(item);
        }

        public List<Item> GetInventory()
        {
            return _items;
        }
    }
}
