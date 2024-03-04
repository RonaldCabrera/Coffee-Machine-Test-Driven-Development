using CoffeeMachine.Constants;

namespace CoffeeMachine.UnitTests
{
    [TestFixture]
    public class CoffeeMachineTests
    {
        private SugarBowl _sugarBowl;
        private CoffeeMaker _coffeeMaker;
        private CoffeeMachine _coffeeMachine;

        private Cup _bigCups;
        private Cup _smallCups;
        private Cup _mediumCups;

        [SetUp]
        public void Setup()
        {
            _sugarBowl = new SugarBowl(20);
            _coffeeMaker = new CoffeeMaker(50);
            _bigCups = new Cup(5, 30, CupType.Big);
            _smallCups = new Cup(5, 10, CupType.Small);
            _mediumCups = new Cup(5, 20, CupType.Medium);

            _coffeeMachine = new CoffeeMachine(_coffeeMaker, _sugarBowl, _smallCups, _mediumCups, _bigCups);
        }

        [Test]
        public void Should_Return_A_Small_Cup()
        {
            Cup smallCups = _coffeeMachine.GetCup(CupType.Small);
            Assert.That(smallCups, Is.EqualTo(_smallCups));
        }

        [Test]
        public void Should_Return_A_Medium_Cup()
        {
            Cup mediumCups = _coffeeMachine.GetCup(CupType.Medium);
            Assert.That(mediumCups, Is.EqualTo(_mediumCups));
        }

        [Test]
        public void Should_Return_A_Big_Cup()
        {
            Cup bigCups = _coffeeMachine.GetCup(CupType.Big);
            Assert.That(bigCups, Is.EqualTo(_bigCups));
        }

        [Test]
        public void Should_Return_Not_Enough_Cups_Error_Message()
        {
            Cup smallCup = _coffeeMachine.GetCup(CupType.Small);
            string resultado = (string) _coffeeMachine.GetCoffeeCup(smallCup, 10, 2);

            Assert.That(resultado, Is.EqualTo(ErrorMessage.NotEnoughCups));
        }

        [Test]
        public void Should_Return_Not_Enough_Coffee_Error_Message()
        {
            _coffeeMaker = new CoffeeMaker(5);
            _coffeeMachine.SetCoffeeMaker(_coffeeMaker);

            Cup smallCup = _coffeeMachine.GetCup(CupType.Small);
            string resultado = (string)_coffeeMachine.GetCoffeeCup(smallCup, 1, 2);

            Assert.That(resultado, Is.EqualTo(ErrorMessage.NotEnoughCoffee));
        }

        [Test]
        public void Should_Return_Not_Enough_Sugar_Error_Message()
        {
            _sugarBowl = new SugarBowl(2);
            _coffeeMachine.SetSugarBowl(_sugarBowl);

            Cup smallCup = _coffeeMachine.GetCup(CupType.Small);
            string resultado = (string)_coffeeMachine.GetCoffeeCup(smallCup, 1, 3);

            Assert.That(resultado, Is.EqualTo(ErrorMessage.NotEnoughSugar));
        }

        [Test]
        public void Should_Return_Congratulations_Error_Message()
        {
            Cup smallCup = _coffeeMachine.GetCup(CupType.Small);
            string resultado = (string)_coffeeMachine.GetCoffeeCup(smallCup, 99, 99);

            Assert.That(resultado, Is.EqualTo(ErrorMessage.Congratulations));
        }

        [Test]
        public void Should_Decrease_Coffee_Amount()
        {
            Cup cup = _coffeeMachine.GetCup(CupType.Small);
            _coffeeMachine.GetCoffeeCup(cup, 1, 3);

            Assert.That(_coffeeMachine.GetCoffeMaker().GetAmount(), Is.EqualTo(40));
        }

        [Test]
        public void Should_Decrease_Cup_Amount()
        {
            Cup cup = _coffeeMachine.GetCup(CupType.Small);
            _coffeeMachine.GetCoffeeCup(cup, 1, 3);

            Assert.That(_coffeeMachine.GetSmallCups().GetAmount(), Is.EqualTo(4));
        }

        [Test]
        public void Should_Decrease_Sugar_Amount()
        {
            Cup cup = _coffeeMachine.GetCup(CupType.Small);
            _coffeeMachine.GetCoffeeCup(cup, 1, 3);

            Assert.That(_coffeeMachine.GetSugarBowl().GetAmount(), Is.EqualTo(17));
        }

        [Test]
        public void Should_Decrease_Coffee_Cup_Sugar_Amount()
        {
            Cup cup = _coffeeMachine.GetCup(CupType.Small);
            _coffeeMachine.GetCoffeeCup(cup, 1, 3);

            Assert.Multiple(() =>
            {
                Assert.That(_coffeeMachine.GetCoffeMaker().GetAmount(), Is.EqualTo(40));
                Assert.That(_coffeeMachine.GetSmallCups().GetAmount(), Is.EqualTo(4));
                Assert.That(_coffeeMachine.GetSugarBowl().GetAmount(), Is.EqualTo(17));
            });
        }
    }
}
