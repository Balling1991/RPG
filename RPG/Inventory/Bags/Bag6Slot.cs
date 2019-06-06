namespace RPG.Inventory.Bags
{
    public class Bag6Slot : Bag
    {
        private readonly int _capacity = 6;

        public Bag6Slot()
        {
        }

        public override int ExtendedCapacity
        {
            get => _capacity;
        }
    }
}
