namespace RPG.Inventory.Bags
{
    public class Bag4Slot : Bag
    {
        private readonly int _capacity = 4;

        public Bag4Slot()
        {
        }

        public override int ExtendedCapacity
        {
            get => _capacity;
        }
    }
}
