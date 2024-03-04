using CoffeeMachine.Constants;

namespace CoffeeMachine
{
    public class Cup(int amount, int content, CupType cupType)
    {
        private int _amount = amount;
        private int _content = content;
        private CupType _type = cupType;

        public void SetAmount(int amount) => _amount = amount;
        public int GetAmount() => _amount;

        public void SetContent(int content) => _content = content;
        public int GetContent() => _content;

        public void SetCupType(CupType cupType) => _type = cupType;
        public CupType GetCupType() => _type;

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
