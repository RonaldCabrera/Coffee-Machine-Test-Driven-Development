using CoffeeMachine.Constants;

namespace CoffeeMachine.UnitTests
{
    public class CupTests
    {
        private Cup _cup;

        [SetUp]
        public void Setup()
        {
            _cup = new Cup(10, 10, CupType.Small);
        }

        [Test]
        public void Should_Return_True_If_There_Are_Enough_Cups()
        {
            Assert.Multiple(() =>
            {
                Assert.That(_cup.HasAmount(5), Is.True);
                Assert.That(_cup.HasAmount(10), Is.True);
            });
        }

        [Test]
        public void Should_Return_False_Because_There_Are_Not_Enough_Cups()
        {
            Assert.That(_cup.HasAmount(15), Is.False);
        }

        [Test]
        public void Should_Decrease_Cup_Amount()
        {
            _cup.DecreaseAmount(5);
            Assert.That(_cup.GetAmount(), Is.EqualTo(5));

            _cup.DecreaseAmount(2);
            Assert.That(_cup.GetAmount(), Is.EqualTo(3));
        }

        [Test]
        public void Should_Return_True_If_Cup_Is_Small()
        {
            Assert.That(_cup.GetCupType(), Is.EqualTo(CupType.Small));
        }
    }
}
