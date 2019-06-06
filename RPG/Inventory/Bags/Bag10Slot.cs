namespace RPG.Inventory.Bags
{
    public class Bag10Slot : Bag
    {
        private readonly int _capacity = 10;

        public Bag10Slot()
        {
        }

        public override int ExtendedCapacity
        {
            get => _capacity;
        }
    }
}
