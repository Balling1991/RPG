using RPG.Inventory.Bags;
using System;
using System.Collections.Generic;

namespace RPG.Inventory
{
    public sealed class Inventory
    {
        public static readonly Inventory Instance = new Inventory();
        private readonly List<Bag> _bagContainer = new List<Bag>();
        private readonly int _baseCapacity = 9;
        private readonly int _maxAmountOfBags = 4;
        private int _fullCapacity;

        private Inventory()
        {
            _fullCapacity = _baseCapacity;
        }

        public List<Bag> AddBag(Bag bag)
        {
            if (_bagContainer.Count == _maxAmountOfBags)
            {
                Console.WriteLine("You cannot equip anymore bags.");
                return _bagContainer;
            }
            _bagContainer.Add(bag);
            _fullCapacity += bag.ExtendedCapacity;

            return _bagContainer;
        }

        public List<Bag> RemoveBag(Bag bag)
        {         
            if (_fullCapacity - bag.ExtendedCapacity < bag.GetAmountOfItems())
            {
                Console.WriteLine("You have too many items in your inventory to remove that bag.");
                return _bagContainer;
            }

            _bagContainer.Remove(bag);
            return _bagContainer;
        }

        public int GetFullCapacity()
        {
            return _fullCapacity;
        }
    }
}
