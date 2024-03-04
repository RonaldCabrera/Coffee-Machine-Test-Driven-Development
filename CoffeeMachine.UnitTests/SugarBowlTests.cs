namespace CoffeeMachine.UnitTests
{
    public class SugarBowlTests
    {
        private SugarBowl _sugarBowl;

        [SetUp]
        public void Setup()
        {
            _sugarBowl = new SugarBowl(10);
        }

        [Test]
        public void Should_Return_True_If_There_Is_Enough_Sugar()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_sugarBowl.HasAmount(5), Is.True);
                Assert.That(_sugarBowl.HasAmount(10), Is.True);
            });
        }

        [Test]
        public void Should_Return_False_Because_There_Isnt_Enough_Sugar()
        {
            Assert.That(_sugarBowl.HasAmount(15), Is.False);
        }

        [Test]
        public void Should_Decrease_Sugar_Amount()
        {
            _sugarBowl.DecreaseAmount(5);
            Assert.That(_sugarBowl.GetAmount(), Is.EqualTo(5));

            _sugarBowl.DecreaseAmount(2);
            Assert.That(_sugarBowl.GetAmount(), Is.EqualTo(3));
        }
    }
}