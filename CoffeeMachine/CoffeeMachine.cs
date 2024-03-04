using CoffeeMachine.Constants;

namespace CoffeeMachine
{
    public class CoffeeMachine(
        CoffeeMaker coffeeMaker, 
        SugarBowl sugarBowl, 
        Cup smallCups, 
        Cup mediumCups, 
        Cup bigCups)
    {
        private CoffeeMaker _coffeeMaker = coffeeMaker;
        private SugarBowl _sugarBowl = sugarBowl;

        private Cup _smallCups = smallCups;
        private Cup _mediumCups = mediumCups;
        private Cup _bigCups = bigCups;

        public Cup GetCup(CupType cupType)
        {
            return cupType switch
            {
                CupType.Small => _smallCups,
                CupType.Medium => _mediumCups,
                CupType.Big => _bigCups,
                _ => _smallCups,
            };
        }

        public object GetCoffeeCup(Cup cup, int cupAmount, int sugarAmount)
        {
            if (cupAmount == 99 && sugarAmount == 99) 
                return ErrorMessage.Congratulations;

            if (!cup.DecreaseAmount(cupAmount))
                return ErrorMessage.NotEnoughCups;

            if (!_sugarBowl.DecreaseAmount(sugarAmount))
                return ErrorMessage.NotEnoughSugar;

            if (!_coffeeMaker.DecreaseAmount(cup.GetContent()))
                return ErrorMessage.NotEnoughCoffee;

            return cup;
        }

        #region Getters & Setters

        public CoffeeMaker GetCoffeMaker() => _coffeeMaker;
        public void SetCoffeeMaker(CoffeeMaker coffeeMaker) => _coffeeMaker = coffeeMaker;

        public Cup GetSmallCups() => _smallCups;
        public void SetVasosPequenos(Cup smallCups) => _smallCups = smallCups;

        public Cup GetMediumCups() => _mediumCups;
        public void SetMediumCups(Cup mediumCups) => _mediumCups = mediumCups;

        public Cup GetBigCups() => _bigCups;
        public void SetBigCups(Cup bigCups) => _bigCups = bigCups;

        public SugarBowl GetSugarBowl() => _sugarBowl;
        public void SetSugarBowl(SugarBowl sugarBowl) => _sugarBowl = sugarBowl;

        #endregion
    }
}
