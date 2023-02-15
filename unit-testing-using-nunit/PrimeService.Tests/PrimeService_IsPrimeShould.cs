using NUnit.Framework;

namespace PrimeService.Tests
{
    [TestFixture]
    public class PrimeService_IsPrimeShould
    {
        private PrimeService_primeService;
        [SetUp]
        public void SetUp()
        {
            _primeService = new PrimeService();
        }
        [Test]
        public void IsPrime_Inputls1_ReturnFalse()
        {
            var result = _primeService.IsPrime(1);
            Assert.IsFalse(result, "1 should not be prime");
        }
    }
}