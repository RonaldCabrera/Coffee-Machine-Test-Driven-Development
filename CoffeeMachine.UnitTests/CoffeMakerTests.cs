namespace CoffeeMachine.UnitTests
{
    public class CoffeMakerTests
    {
        private CoffeeMaker _coffeeMaker;

        [SetUp]
        public void Setup()
        {
            _coffeeMaker = new CoffeeMaker(10);
        }

        [Test]
        public void Should_Return_True_If_There_Is_Enough_Coffee()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_coffeeMaker.HasAmount(5), Is.True);
                Assert.That(_coffeeMaker.HasAmount(10), Is.True);
            });
        }

        [Test]
        public void Should_Return_False_Because_There_Isnt_Enough_Sugar()
        {
            Assert.That(_coffeeMaker.HasAmount(11), Is.False);
        }

        [Test]
        public void Should_Decrease_Coffee_Amount()
        {
            _coffeeMaker.DecreaseAmount(7);
            Assert.That(_coffeeMaker.GetAmount(), Is.EqualTo(3));
        }
    }
}
