namespace CoffeeMachine
{
    public class CoffeeMaker(int amount)
    {
        private int _amount = amount;

        public int GetAmount() => _amount;
        public void SetAmount(int amount) => _amount = amount;

        public bool HasAmount(int amount) => _amount >= amount;
        public bool DecreaseAmount(int amount)
        {
            if (HasAmount(amount))
            {
                _amount -= amount;
                return true;
            }

            return false;
        }
    }
}